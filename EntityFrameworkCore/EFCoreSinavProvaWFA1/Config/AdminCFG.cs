using EFCoreSinavProvaWFA1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSinavProvaWFA1.Config
{
    public class AdminCFG : IEntityTypeConfiguration<Models.Admin>
    {
        public void Configure(EntityTypeBuilder<Models.Admin> builder)
        {
            builder.ToTable("ADMINLER");
        }
    }
}
