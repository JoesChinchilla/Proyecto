﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Entidades.Persona;
using Proyecto.Entidades.Rol;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Datos.Mapping.Roles
{
    public class RolMap : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder.ToTable("Rol")
                .HasKey(c => c.idrol);
            builder.Property(c => c.nombrerol)
                .HasMaxLength(50);
            builder.Property(c => c.descripcionrol)
                .HasMaxLength(256);
            builder.Property(c => c.condicion)
                .HasMaxLength(256);
            
        }
    }
}
