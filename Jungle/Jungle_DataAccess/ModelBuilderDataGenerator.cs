﻿using Jungle_Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_DataAccess.Repository
{
    public static class ModelBuilderDataGenerator
    {
        public static void GenerateData(this ModelBuilder builder)
        {
            #region Données pour Country
            builder.Entity<Country>().HasData(new Country() { Id = 1, Name = "France" });
            builder.Entity<Country>().HasData(new Country() { Id = 2, Name = "Italie" });
            builder.Entity<Country>().HasData(new Country() { Id = 3, Name = "Mexique" });
            builder.Entity<Country>().HasData(new Country() { Id = 4, Name = "Turquie" });
            builder.Entity<Country>().HasData(new Country() { Id = 5, Name = "Allemagne" });
            #endregion

            #region Données pour Destination
            builder.Entity<Destination>().HasData(new Destination() { Id = 1, Country_Id = 1, Name = "Basse Alsace", Region = "Alsace" });
            builder.Entity<Destination>().HasData(new Destination() { Id = 2, Country_Id = 1, Name = "Gironde", Region = "Aquitaine" });
            builder.Entity<Destination>().HasData(new Destination() { Id = 3, Country_Id = 2, Name = "Rallye de Sardaigne", Region = "Sardaigne" });
            builder.Entity<Destination>().HasData(new Destination() { Id = 4, Country_Id = 2, Name = "Tournée de vignobles", Region = "Toscane" });
            builder.Entity<Destination>().HasData(new Destination() { Id = 5, Country_Id = 3, Name = "Surf Extrême", Region = "Yucatan" });
            builder.Entity<Destination>().HasData(new Destination() { Id = 6, Country_Id = 4, Name = "Samsun", Region = "Mer Noire" });
            builder.Entity<Destination>().HasData(new Destination() { Id = 7, Country_Id = 3, Name = "Bassin du Danube", Region = "Bavière" });
            builder.Entity<Destination>().HasData(new Destination() { Id = 8, Country_Id = 3, Name = "Landes", Region = "Brandebourg " });
            #endregion

            #region Données pour Guide
            builder.Entity<Guide>().HasData(new Guide() { Id = 1, FirstName = "Aqua", LastName = "Man", Speciality = "Activités nautiques" });
            builder.Entity<Guide>().HasData(new Guide() { Id = 2, FirstName = "Wonder", LastName = "Woman", Speciality = "Escalade" });
            builder.Entity<Guide>().HasData(new Guide() { Id = 3, FirstName = "Iron", LastName = "Man", Speciality = "Randonnée" });
            #endregion

            #region Données pour Country
            builder.Entity<Country>().HasData(new Country() { Id = 1, Name = "France" });

            #endregion
        }

    }
}