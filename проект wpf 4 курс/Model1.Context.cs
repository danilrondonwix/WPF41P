﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------


namespace WPF41P
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class Entities : DbContext
{
    public Entities()
        : base("name=Entities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<auth> auth { get; set; }

    public virtual DbSet<genders> genders { get; set; }

    public virtual DbSet<roles> roles { get; set; }

    public virtual DbSet<traits> traits { get; set; }

    public virtual DbSet<users> users { get; set; }

    public virtual DbSet<users_to_traits> users_to_traits { get; set; }

    public virtual DbSet<usersimage> usersimage { get; set; }

}

}

