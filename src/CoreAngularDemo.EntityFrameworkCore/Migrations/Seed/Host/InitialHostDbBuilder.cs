using CoreAngularDemo.EntityFrameworkCore;

namespace CoreAngularDemo.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly CoreAngularDemoDbContext _context;

        public InitialHostDbBuilder(CoreAngularDemoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            new InitialPeopleAndPhoneCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
