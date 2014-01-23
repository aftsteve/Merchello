﻿using System;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace Merchello.Core.Models.Rdbms
{
    [TableName("merchShipCountry2GatewayProvider")]
    [PrimaryKey("shipCountryKey", autoIncrement = false)]
    [ExplicitColumns]
    public class ShipCountry2GatewayProviderDto
    {
        [Column("shipCountryKey")]
        [PrimaryKeyColumn(AutoIncrement = false, Name = "PK_merchShipCountry2GatewayProvider", OnColumns = "shipCountryKey, gatewayProviderKey")]
        [ForeignKey(typeof(ShipCountryDto), Name = "FK_merchShipCountry2GatewayProvider_merchShipCountry", Column = "pk")]
        public Guid ShipCountrytKey { get; set; }

        [Column("gatewayProviderKey")]
        [ForeignKey(typeof(GatewayProviderDto), Name = "FK_merchShipCountry2GatewayProvider_merchGatewayProvider", Column = "pk")]
        public Guid GatewayProvidertKey { get; set; }

        [Column("updateDate")]
        [Constraint(Default = "getdate()")]
        public DateTime UpdateDate { get; set; }

        [Column("createDate")]
        [Constraint(Default = "getdate()")]
        public DateTime CreateDate { get; set; }

        [ResultColumn]
        public GatewayProviderDto GatewayProviderDto { get; set; }
    }
}