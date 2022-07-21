using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfrastructureLayer.Migrations
{
    public partial class batch8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VehicleRegistration",
                schema: "Warehouse",
                table: "VehicleTemperatures",
                type: "nvarchar(28)",
                maxLength: 28,
                nullable: false,
                collation: "Latin1_General_CI_AS",
                oldClrType: typeof(string),
                oldType: "nvarchar(27)",
                oldMaxLength: 27,
                oldCollation: "Latin1_General_CI_AS");

            migrationBuilder.AlterColumn<string>(
                name: "FullSensorData",
                schema: "Warehouse",
                table: "VehicleTemperatures",
                type: "nvarchar(1008)",
                maxLength: 1008,
                nullable: true,
                collation: "Latin1_General_CI_AS",
                oldClrType: typeof(string),
                oldType: "nvarchar(1007)",
                oldMaxLength: 1007,
                oldNullable: true,
                oldCollation: "Latin1_General_CI_AS");

            migrationBuilder.AlterColumn<string>(
                name: "TransactionTypeName",
                schema: "Application",
                table: "TransactionTypes",
                type: "nvarchar(58)",
                maxLength: 58,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(57)",
                oldMaxLength: 57);

            migrationBuilder.AlterColumn<string>(
                name: "PostalPostalCode",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(17)",
                oldMaxLength: 17);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine2",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(68)",
                maxLength: 68,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(67)",
                oldMaxLength: 67,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine1",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(68)",
                maxLength: 68,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(67)",
                oldMaxLength: 67);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryPostalCode",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(17)",
                oldMaxLength: 17);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine2",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(68)",
                maxLength: 68,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(67)",
                oldMaxLength: 67,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine1",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(68)",
                maxLength: 68,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(67)",
                oldMaxLength: 67);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierInvoiceNumber",
                schema: "Purchasing",
                table: "SupplierTransactions",
                type: "nvarchar(28)",
                maxLength: 28,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(27)",
                oldMaxLength: 27,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WebsiteURL",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(264)",
                maxLength: 264,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(263)",
                oldMaxLength: 263);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierReference",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(28)",
                maxLength: 28,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(27)",
                oldMaxLength: 27,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalPostalCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(17)",
                oldMaxLength: 17);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine2",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(68)",
                maxLength: 68,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(67)",
                oldMaxLength: 67,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine1",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(68)",
                maxLength: 68,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(67)",
                oldMaxLength: 67);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(28)",
                maxLength: 28,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(27)",
                oldMaxLength: 27);

            migrationBuilder.AlterColumn<string>(
                name: "FaxNumber",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(28)",
                maxLength: 28,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(27)",
                oldMaxLength: 27);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryPostalCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(17)",
                oldMaxLength: 17);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine2",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(68)",
                maxLength: 68,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(67)",
                oldMaxLength: 67,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine1",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(68)",
                maxLength: 68,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(67)",
                oldMaxLength: 67);

            migrationBuilder.AlterColumn<string>(
                name: "BankInternationalCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(28)",
                maxLength: 28,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(27)",
                oldMaxLength: 27,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountNumber",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(28)",
                maxLength: 28,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(27)",
                oldMaxLength: 27,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountName",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(58)",
                maxLength: 58,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(57)",
                oldMaxLength: 57,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(28)",
                maxLength: 28,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(27)",
                oldMaxLength: 27,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountBranch",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(58)",
                maxLength: 58,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(57)",
                oldMaxLength: 57,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierCategoryName",
                schema: "Purchasing",
                table: "SupplierCategories",
                type: "nvarchar(58)",
                maxLength: 58,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(57)",
                oldMaxLength: 57);

            migrationBuilder.AlterColumn<string>(
                name: "Size",
                schema: "Warehouse",
                table: "StockItems",
                type: "nvarchar(28)",
                maxLength: 28,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(27)",
                oldMaxLength: 27,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                schema: "Warehouse",
                table: "StockItems",
                type: "nvarchar(58)",
                maxLength: 58,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(57)",
                oldMaxLength: 57,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Barcode",
                schema: "Warehouse",
                table: "StockItems",
                type: "nvarchar(58)",
                maxLength: 58,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(57)",
                oldMaxLength: 57,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BinLocation",
                schema: "Warehouse",
                table: "StockItemHoldings",
                type: "nvarchar(28)",
                maxLength: 28,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(27)",
                oldMaxLength: 27);

            migrationBuilder.AlterColumn<string>(
                name: "StockGroupName",
                schema: "Warehouse",
                table: "StockGroups",
                type: "nvarchar(58)",
                maxLength: 58,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(57)",
                oldMaxLength: 57);

            migrationBuilder.AlterColumn<string>(
                name: "StateProvinceName",
                schema: "Application",
                table: "StateProvinces",
                type: "nvarchar(58)",
                maxLength: 58,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(57)",
                oldMaxLength: 57);

            migrationBuilder.AlterColumn<string>(
                name: "StateProvinceCode",
                schema: "Application",
                table: "StateProvinces",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "SalesTerritory",
                schema: "Application",
                table: "StateProvinces",
                type: "nvarchar(58)",
                maxLength: 58,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(57)",
                oldMaxLength: 57);

            migrationBuilder.AlterColumn<string>(
                name: "DealDescription",
                schema: "Sales",
                table: "SpecialDeals",
                type: "nvarchar(38)",
                maxLength: 38,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(37)",
                oldMaxLength: 37);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierReference",
                schema: "Purchasing",
                table: "PurchaseOrders",
                type: "nvarchar(28)",
                maxLength: 28,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(27)",
                oldMaxLength: 27,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PreferredName",
                schema: "Application",
                table: "People",
                type: "nvarchar(58)",
                maxLength: 58,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(57)",
                oldMaxLength: 57);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "Application",
                table: "People",
                type: "nvarchar(28)",
                maxLength: 28,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(27)",
                oldMaxLength: 27,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LogonName",
                schema: "Application",
                table: "People",
                type: "nvarchar(58)",
                maxLength: 58,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(57)",
                oldMaxLength: 57,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                schema: "Application",
                table: "People",
                type: "nvarchar(58)",
                maxLength: 58,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(57)",
                oldMaxLength: 57);

            migrationBuilder.AlterColumn<string>(
                name: "FaxNumber",
                schema: "Application",
                table: "People",
                type: "nvarchar(28)",
                maxLength: 28,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(27)",
                oldMaxLength: 27,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                schema: "Application",
                table: "People",
                type: "nvarchar(264)",
                maxLength: 264,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(263)",
                oldMaxLength: 263,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PaymentMethodName",
                schema: "Application",
                table: "PaymentMethods",
                type: "nvarchar(58)",
                maxLength: 58,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(57)",
                oldMaxLength: 57);

            migrationBuilder.AlterColumn<string>(
                name: "PackageTypeName",
                schema: "Warehouse",
                table: "PackageTypes",
                type: "nvarchar(58)",
                maxLength: 58,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(57)",
                oldMaxLength: 57);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerPurchaseOrderNumber",
                schema: "Sales",
                table: "Orders",
                type: "nvarchar(28)",
                maxLength: 28,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(27)",
                oldMaxLength: 27,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RunPosition",
                schema: "Sales",
                table: "Invoices",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryRun",
                schema: "Sales",
                table: "Invoices",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerPurchaseOrderNumber",
                schema: "Sales",
                table: "Invoices",
                type: "nvarchar(28)",
                maxLength: 28,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(27)",
                oldMaxLength: 27,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryMethodName",
                schema: "Application",
                table: "DeliveryMethods",
                type: "nvarchar(58)",
                maxLength: 58,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(57)",
                oldMaxLength: 57);

            migrationBuilder.AlterColumn<string>(
                name: "WebsiteURL",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(264)",
                maxLength: 264,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(263)",
                oldMaxLength: 263);

            migrationBuilder.AlterColumn<string>(
                name: "RunPosition",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalPostalCode",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(17)",
                oldMaxLength: 17);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine2",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(68)",
                maxLength: 68,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(67)",
                oldMaxLength: 67,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine1",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(68)",
                maxLength: 68,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(67)",
                oldMaxLength: 67);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(28)",
                maxLength: 28,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(27)",
                oldMaxLength: 27);

            migrationBuilder.AlterColumn<string>(
                name: "FaxNumber",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(28)",
                maxLength: 28,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(27)",
                oldMaxLength: 27);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryRun",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryPostalCode",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(17)",
                oldMaxLength: 17);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine2",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(68)",
                maxLength: 68,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(67)",
                oldMaxLength: 67,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine1",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(68)",
                maxLength: 68,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(67)",
                oldMaxLength: 67);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerCategoryName",
                schema: "Sales",
                table: "CustomerCategories",
                type: "nvarchar(58)",
                maxLength: 58,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(57)",
                oldMaxLength: 57);

            migrationBuilder.AlterColumn<string>(
                name: "Subregion",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(38)",
                maxLength: 38,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(37)",
                oldMaxLength: 37);

            migrationBuilder.AlterColumn<string>(
                name: "Region",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(38)",
                maxLength: 38,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(37)",
                oldMaxLength: 37);

            migrationBuilder.AlterColumn<string>(
                name: "IsoAlpha3Code",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FormalName",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(68)",
                maxLength: 68,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(67)",
                oldMaxLength: 67);

            migrationBuilder.AlterColumn<string>(
                name: "CountryType",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(28)",
                maxLength: 28,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(27)",
                oldMaxLength: 27,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CountryName",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(68)",
                maxLength: 68,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(67)",
                oldMaxLength: 67);

            migrationBuilder.AlterColumn<string>(
                name: "Continent",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(38)",
                maxLength: 38,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(37)",
                oldMaxLength: 37);

            migrationBuilder.AlterColumn<string>(
                name: "ColorName",
                schema: "Warehouse",
                table: "Colors",
                type: "nvarchar(28)",
                maxLength: 28,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(27)",
                oldMaxLength: 27);

            migrationBuilder.AlterColumn<string>(
                name: "CityName",
                schema: "Application",
                table: "Cities",
                type: "nvarchar(58)",
                maxLength: 58,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(57)",
                oldMaxLength: 57);

            migrationBuilder.AlterColumn<string>(
                name: "BuyingGroupName",
                schema: "Sales",
                table: "BuyingGroups",
                type: "nvarchar(58)",
                maxLength: 58,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(57)",
                oldMaxLength: 57);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VehicleRegistration",
                schema: "Warehouse",
                table: "VehicleTemperatures",
                type: "nvarchar(27)",
                maxLength: 27,
                nullable: false,
                collation: "Latin1_General_CI_AS",
                oldClrType: typeof(string),
                oldType: "nvarchar(28)",
                oldMaxLength: 28,
                oldCollation: "Latin1_General_CI_AS");

            migrationBuilder.AlterColumn<string>(
                name: "FullSensorData",
                schema: "Warehouse",
                table: "VehicleTemperatures",
                type: "nvarchar(1007)",
                maxLength: 1007,
                nullable: true,
                collation: "Latin1_General_CI_AS",
                oldClrType: typeof(string),
                oldType: "nvarchar(1008)",
                oldMaxLength: 1008,
                oldNullable: true,
                oldCollation: "Latin1_General_CI_AS");

            migrationBuilder.AlterColumn<string>(
                name: "TransactionTypeName",
                schema: "Application",
                table: "TransactionTypes",
                type: "nvarchar(57)",
                maxLength: 57,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(58)",
                oldMaxLength: 58);

            migrationBuilder.AlterColumn<string>(
                name: "PostalPostalCode",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(17)",
                maxLength: 17,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine2",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(67)",
                maxLength: 67,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(68)",
                oldMaxLength: 68,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine1",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(67)",
                maxLength: 67,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(68)",
                oldMaxLength: 68);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryPostalCode",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(17)",
                maxLength: 17,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine2",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(67)",
                maxLength: 67,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(68)",
                oldMaxLength: 68,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine1",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(67)",
                maxLength: 67,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(68)",
                oldMaxLength: 68);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierInvoiceNumber",
                schema: "Purchasing",
                table: "SupplierTransactions",
                type: "nvarchar(27)",
                maxLength: 27,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(28)",
                oldMaxLength: 28,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WebsiteURL",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(263)",
                maxLength: 263,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(264)",
                oldMaxLength: 264);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierReference",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(27)",
                maxLength: 27,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(28)",
                oldMaxLength: 28,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalPostalCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(17)",
                maxLength: 17,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine2",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(67)",
                maxLength: 67,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(68)",
                oldMaxLength: 68,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine1",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(67)",
                maxLength: 67,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(68)",
                oldMaxLength: 68);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(27)",
                maxLength: 27,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(28)",
                oldMaxLength: 28);

            migrationBuilder.AlterColumn<string>(
                name: "FaxNumber",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(27)",
                maxLength: 27,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(28)",
                oldMaxLength: 28);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryPostalCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(17)",
                maxLength: 17,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine2",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(67)",
                maxLength: 67,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(68)",
                oldMaxLength: 68,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine1",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(67)",
                maxLength: 67,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(68)",
                oldMaxLength: 68);

            migrationBuilder.AlterColumn<string>(
                name: "BankInternationalCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(27)",
                maxLength: 27,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(28)",
                oldMaxLength: 28,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountNumber",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(27)",
                maxLength: 27,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(28)",
                oldMaxLength: 28,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountName",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(57)",
                maxLength: 57,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(58)",
                oldMaxLength: 58,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(27)",
                maxLength: 27,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(28)",
                oldMaxLength: 28,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountBranch",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(57)",
                maxLength: 57,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(58)",
                oldMaxLength: 58,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierCategoryName",
                schema: "Purchasing",
                table: "SupplierCategories",
                type: "nvarchar(57)",
                maxLength: 57,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(58)",
                oldMaxLength: 58);

            migrationBuilder.AlterColumn<string>(
                name: "Size",
                schema: "Warehouse",
                table: "StockItems",
                type: "nvarchar(27)",
                maxLength: 27,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(28)",
                oldMaxLength: 28,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                schema: "Warehouse",
                table: "StockItems",
                type: "nvarchar(57)",
                maxLength: 57,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(58)",
                oldMaxLength: 58,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Barcode",
                schema: "Warehouse",
                table: "StockItems",
                type: "nvarchar(57)",
                maxLength: 57,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(58)",
                oldMaxLength: 58,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BinLocation",
                schema: "Warehouse",
                table: "StockItemHoldings",
                type: "nvarchar(27)",
                maxLength: 27,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(28)",
                oldMaxLength: 28);

            migrationBuilder.AlterColumn<string>(
                name: "StockGroupName",
                schema: "Warehouse",
                table: "StockGroups",
                type: "nvarchar(57)",
                maxLength: 57,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(58)",
                oldMaxLength: 58);

            migrationBuilder.AlterColumn<string>(
                name: "StateProvinceName",
                schema: "Application",
                table: "StateProvinces",
                type: "nvarchar(57)",
                maxLength: 57,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(58)",
                oldMaxLength: 58);

            migrationBuilder.AlterColumn<string>(
                name: "StateProvinceCode",
                schema: "Application",
                table: "StateProvinces",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "SalesTerritory",
                schema: "Application",
                table: "StateProvinces",
                type: "nvarchar(57)",
                maxLength: 57,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(58)",
                oldMaxLength: 58);

            migrationBuilder.AlterColumn<string>(
                name: "DealDescription",
                schema: "Sales",
                table: "SpecialDeals",
                type: "nvarchar(37)",
                maxLength: 37,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(38)",
                oldMaxLength: 38);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierReference",
                schema: "Purchasing",
                table: "PurchaseOrders",
                type: "nvarchar(27)",
                maxLength: 27,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(28)",
                oldMaxLength: 28,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PreferredName",
                schema: "Application",
                table: "People",
                type: "nvarchar(57)",
                maxLength: 57,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(58)",
                oldMaxLength: 58);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "Application",
                table: "People",
                type: "nvarchar(27)",
                maxLength: 27,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(28)",
                oldMaxLength: 28,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LogonName",
                schema: "Application",
                table: "People",
                type: "nvarchar(57)",
                maxLength: 57,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(58)",
                oldMaxLength: 58,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                schema: "Application",
                table: "People",
                type: "nvarchar(57)",
                maxLength: 57,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(58)",
                oldMaxLength: 58);

            migrationBuilder.AlterColumn<string>(
                name: "FaxNumber",
                schema: "Application",
                table: "People",
                type: "nvarchar(27)",
                maxLength: 27,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(28)",
                oldMaxLength: 28,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                schema: "Application",
                table: "People",
                type: "nvarchar(263)",
                maxLength: 263,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(264)",
                oldMaxLength: 264,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PaymentMethodName",
                schema: "Application",
                table: "PaymentMethods",
                type: "nvarchar(57)",
                maxLength: 57,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(58)",
                oldMaxLength: 58);

            migrationBuilder.AlterColumn<string>(
                name: "PackageTypeName",
                schema: "Warehouse",
                table: "PackageTypes",
                type: "nvarchar(57)",
                maxLength: 57,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(58)",
                oldMaxLength: 58);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerPurchaseOrderNumber",
                schema: "Sales",
                table: "Orders",
                type: "nvarchar(27)",
                maxLength: 27,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(28)",
                oldMaxLength: 28,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RunPosition",
                schema: "Sales",
                table: "Invoices",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryRun",
                schema: "Sales",
                table: "Invoices",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerPurchaseOrderNumber",
                schema: "Sales",
                table: "Invoices",
                type: "nvarchar(27)",
                maxLength: 27,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(28)",
                oldMaxLength: 28,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryMethodName",
                schema: "Application",
                table: "DeliveryMethods",
                type: "nvarchar(57)",
                maxLength: 57,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(58)",
                oldMaxLength: 58);

            migrationBuilder.AlterColumn<string>(
                name: "WebsiteURL",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(263)",
                maxLength: 263,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(264)",
                oldMaxLength: 264);

            migrationBuilder.AlterColumn<string>(
                name: "RunPosition",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalPostalCode",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(17)",
                maxLength: 17,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine2",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(67)",
                maxLength: 67,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(68)",
                oldMaxLength: 68,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine1",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(67)",
                maxLength: 67,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(68)",
                oldMaxLength: 68);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(27)",
                maxLength: 27,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(28)",
                oldMaxLength: 28);

            migrationBuilder.AlterColumn<string>(
                name: "FaxNumber",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(27)",
                maxLength: 27,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(28)",
                oldMaxLength: 28);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryRun",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryPostalCode",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(17)",
                maxLength: 17,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine2",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(67)",
                maxLength: 67,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(68)",
                oldMaxLength: 68,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine1",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(67)",
                maxLength: 67,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(68)",
                oldMaxLength: 68);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerCategoryName",
                schema: "Sales",
                table: "CustomerCategories",
                type: "nvarchar(57)",
                maxLength: 57,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(58)",
                oldMaxLength: 58);

            migrationBuilder.AlterColumn<string>(
                name: "Subregion",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(37)",
                maxLength: 37,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(38)",
                oldMaxLength: 38);

            migrationBuilder.AlterColumn<string>(
                name: "Region",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(37)",
                maxLength: 37,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(38)",
                oldMaxLength: 38);

            migrationBuilder.AlterColumn<string>(
                name: "IsoAlpha3Code",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FormalName",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(67)",
                maxLength: 67,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(68)",
                oldMaxLength: 68);

            migrationBuilder.AlterColumn<string>(
                name: "CountryType",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(27)",
                maxLength: 27,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(28)",
                oldMaxLength: 28,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CountryName",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(67)",
                maxLength: 67,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(68)",
                oldMaxLength: 68);

            migrationBuilder.AlterColumn<string>(
                name: "Continent",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(37)",
                maxLength: 37,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(38)",
                oldMaxLength: 38);

            migrationBuilder.AlterColumn<string>(
                name: "ColorName",
                schema: "Warehouse",
                table: "Colors",
                type: "nvarchar(27)",
                maxLength: 27,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(28)",
                oldMaxLength: 28);

            migrationBuilder.AlterColumn<string>(
                name: "CityName",
                schema: "Application",
                table: "Cities",
                type: "nvarchar(57)",
                maxLength: 57,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(58)",
                oldMaxLength: 58);

            migrationBuilder.AlterColumn<string>(
                name: "BuyingGroupName",
                schema: "Sales",
                table: "BuyingGroups",
                type: "nvarchar(57)",
                maxLength: 57,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(58)",
                oldMaxLength: 58);
        }
    }
}
