 using ASPCORE.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCORE.AppDBContext
{
    public class VroomDbContext : IdentityDbContext<IdentityUser>
    {
        public VroomDbContext(DbContextOptions<VroomDbContext> options) : base(options)
        {

        }
        public DbSet<Make> makes { get; set; }
        public DbSet<Model> models { get; set; }
        public DbSet<Bike> Bikes { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Loanusers> Loanusers { get; set; }
        public DbSet<LoanDetails> loanDetails { get; set; }
        public DbSet<StockInvestorDetails> StockInvestorDetails {get;set;}
        public DbSet<MasterStockDetails> masterStockDetails { get; set; }
        public DbSet<InvestmentMaster> investmentMasters { get; set; }
        public DbSet<PayOutDetails> payOutDetails { get; set; }
        public DbSet<PayoutDescriptionDetails> payoutDescriptionDetails { get; set; }

    }
}
