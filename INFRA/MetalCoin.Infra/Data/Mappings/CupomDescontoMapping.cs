using Metalcoin.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalCoin.Infra.Data.Mappings
{
    public class CupomDescontoMapping : IEntityTypeConfiguration<CupomDesconto>
    {
        public void Configure(EntityTypeBuilder<CupomDesconto> builder)
        {
            builder.ToTable("CupomDesconto");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Codigo)
                .HasColumnType("varchar(1000)")
                .IsRequired();

            builder.Property(p => p.Descricao)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(p => p.CuponsLiberados)
                .HasColumnType("varchar(1000)")
                .IsRequired();
            builder.Property(p => p.CuponsUsados)
                .HasColumnType("varchar(1000)")
                .IsRequired();
            builder.Property(p => p.Status)
               .HasColumnType("bit")
               .IsRequired();



        }
    }
}
