namespace Asd.Infra.Data.UoW
{
    using Asd.Domain.Core.Commands;
    using Asd.Domain.Interfaces;
    using Asd.Infra.Data.Context;
    using System;

    public class AsdUnitOfWork : IAsdUnitOfWork
    {
        private readonly AsdSqlContext _context;

        public AsdUnitOfWork(AsdSqlContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public AsdCommandResponse Commit()
        {
            return _context.SaveChanges() > 0 ? AsdCommandResponse.Ok : AsdCommandResponse.Fail;
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
