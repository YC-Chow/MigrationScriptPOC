using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfrastructureLayer.Migrations
{
    public partial class batch1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VehicleRegistration",
                schema: "Warehouse",
                table: "VehicleTemperatures",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                collation: "Latin1_General_CI_AS",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldCollation: "Latin1_General_CI_AS");

            migrationBuilder.AlterColumn<string>(
                name: "FullSensorData",
                schema: "Warehouse",
                table: "VehicleTemperatures",
                type: "nvarchar(1001)",
                maxLength: 1001,
                nullable: true,
                collation: "Latin1_General_CI_AS",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true,
                oldCollation: "Latin1_General_CI_AS");

            migrationBuilder.AlterColumn<string>(
                name: "TransactionTypeName",
                schema: "Application",
                table: "TransactionTypes",
                type: "nvarchar(51)",
                maxLength: 51,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PostalPostalCode",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine2",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(61)",
                maxLength: 61,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine1",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(61)",
                maxLength: 61,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryPostalCode",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine2",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(61)",
                maxLength: 61,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine1",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(61)",
                maxLength: 61,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierInvoiceNumber",
                schema: "Purchasing",
                table: "SupplierTransactions",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WebsiteURL",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(257)",
                maxLength: 257,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierReference",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierName",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(101)",
                maxLength: 101,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "PostalPostalCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine2",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(61)",
                maxLength: 61,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine1",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(61)",
                maxLength: 61,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "FaxNumber",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryPostalCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine2",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(61)",
                maxLength: 61,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine1",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(61)",
                maxLength: 61,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "BankInternationalCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountNumber",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountName",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(51)",
                maxLength: 51,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountBranch",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(51)",
                maxLength: 51,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierCategoryName",
                schema: "Purchasing",
                table: "SupplierCategories",
                type: "nvarchar(51)",
                maxLength: 51,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "StockItemName",
                schema: "Warehouse",
                table: "StockItems",
                type: "nvarchar(101)",
                maxLength: 101,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Size",
                schema: "Warehouse",
                table: "StockItems",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                schema: "Warehouse",
                table: "StockItems",
                type: "nvarchar(51)",
                maxLength: 51,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Barcode",
                schema: "Warehouse",
                table: "StockItems",
                type: "nvarchar(51)",
                maxLength: 51,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BinLocation",
                schema: "Warehouse",
                table: "StockItemHoldings",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "StockGroupName",
                schema: "Warehouse",
                table: "StockGroups",
                type: "nvarchar(51)",
                maxLength: 51,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "StateProvinceName",
                schema: "Application",
                table: "StateProvinces",
                type: "nvarchar(51)",
                maxLength: 51,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "StateProvinceCode",
                schema: "Application",
                table: "StateProvinces",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "SalesTerritory",
                schema: "Application",
                table: "StateProvinces",
                type: "nvarchar(51)",
                maxLength: 51,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "DealDescription",
                schema: "Sales",
                table: "SpecialDeals",
                type: "nvarchar(31)",
                maxLength: 31,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierReference",
                schema: "Purchasing",
                table: "PurchaseOrders",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Purchasing",
                table: "PurchaseOrderLines",
                type: "nvarchar(101)",
                maxLength: 101,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "PreferredName",
                schema: "Application",
                table: "People",
                type: "nvarchar(51)",
                maxLength: 51,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "Application",
                table: "People",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LogonName",
                schema: "Application",
                table: "People",
                type: "nvarchar(51)",
                maxLength: 51,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                schema: "Application",
                table: "People",
                type: "nvarchar(51)",
                maxLength: 51,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FaxNumber",
                schema: "Application",
                table: "People",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                schema: "Application",
                table: "People",
                type: "nvarchar(257)",
                maxLength: 257,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PaymentMethodName",
                schema: "Application",
                table: "PaymentMethods",
                type: "nvarchar(51)",
                maxLength: 51,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PackageTypeName",
                schema: "Warehouse",
                table: "PackageTypes",
                type: "nvarchar(51)",
                maxLength: 51,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerPurchaseOrderNumber",
                schema: "Sales",
                table: "Orders",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Sales",
                table: "OrderLines",
                type: "nvarchar(101)",
                maxLength: 101,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "RunPosition",
                schema: "Sales",
                table: "Invoices",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryRun",
                schema: "Sales",
                table: "Invoices",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerPurchaseOrderNumber",
                schema: "Sales",
                table: "Invoices",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Sales",
                table: "InvoiceLines",
                type: "nvarchar(101)",
                maxLength: 101,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryMethodName",
                schema: "Application",
                table: "DeliveryMethods",
                type: "nvarchar(51)",
                maxLength: 51,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "WebsiteURL",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(257)",
                maxLength: 257,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "RunPosition",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalPostalCode",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine2",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(61)",
                maxLength: 61,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine1",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(61)",
                maxLength: 61,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "FaxNumber",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryRun",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryPostalCode",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine2",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(61)",
                maxLength: 61,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine1",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(61)",
                maxLength: 61,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(101)",
                maxLength: 101,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerCategoryName",
                schema: "Sales",
                table: "CustomerCategories",
                type: "nvarchar(51)",
                maxLength: 51,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Subregion",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(31)",
                maxLength: 31,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Region",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(31)",
                maxLength: 31,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "IsoAlpha3Code",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FormalName",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(61)",
                maxLength: 61,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "CountryType",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CountryName",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(61)",
                maxLength: 61,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "Continent",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(31)",
                maxLength: 31,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "ColorName",
                schema: "Warehouse",
                table: "Colors",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "BuyingGroupName",
                schema: "Sales",
                table: "BuyingGroups",
                type: "nvarchar(51)",
                maxLength: 51,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VehicleRegistration",
                schema: "Warehouse",
                table: "VehicleTemperatures",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                collation: "Latin1_General_CI_AS",
                oldClrType: typeof(string),
                oldType: "nvarchar(21)",
                oldMaxLength: 21,
                oldCollation: "Latin1_General_CI_AS");

            migrationBuilder.AlterColumn<string>(
                name: "FullSensorData",
                schema: "Warehouse",
                table: "VehicleTemperatures",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                collation: "Latin1_General_CI_AS",
                oldClrType: typeof(string),
                oldType: "nvarchar(1001)",
                oldMaxLength: 1001,
                oldNullable: true,
                oldCollation: "Latin1_General_CI_AS");

            migrationBuilder.AlterColumn<string>(
                name: "TransactionTypeName",
                schema: "Application",
                table: "TransactionTypes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(51)",
                oldMaxLength: 51);

            migrationBuilder.AlterColumn<string>(
                name: "PostalPostalCode",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine2",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(61)",
                oldMaxLength: 61,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine1",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(61)",
                oldMaxLength: 61);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryPostalCode",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine2",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(61)",
                oldMaxLength: 61,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine1",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(61)",
                oldMaxLength: 61);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierInvoiceNumber",
                schema: "Purchasing",
                table: "SupplierTransactions",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(21)",
                oldMaxLength: 21,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WebsiteURL",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(257)",
                oldMaxLength: 257);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierReference",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(21)",
                oldMaxLength: 21,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierName",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(101)",
                oldMaxLength: 101);

            migrationBuilder.AlterColumn<string>(
                name: "PostalPostalCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine2",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(61)",
                oldMaxLength: 61,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine1",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(61)",
                oldMaxLength: 61);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(21)",
                oldMaxLength: 21);

            migrationBuilder.AlterColumn<string>(
                name: "FaxNumber",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(21)",
                oldMaxLength: 21);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryPostalCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine2",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(61)",
                oldMaxLength: 61,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine1",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(61)",
                oldMaxLength: 61);

            migrationBuilder.AlterColumn<string>(
                name: "BankInternationalCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(21)",
                oldMaxLength: 21,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountNumber",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(21)",
                oldMaxLength: 21,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountName",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(51)",
                oldMaxLength: 51,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(21)",
                oldMaxLength: 21,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountBranch",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(51)",
                oldMaxLength: 51,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierCategoryName",
                schema: "Purchasing",
                table: "SupplierCategories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(51)",
                oldMaxLength: 51);

            migrationBuilder.AlterColumn<string>(
                name: "StockItemName",
                schema: "Warehouse",
                table: "StockItems",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(101)",
                oldMaxLength: 101);

            migrationBuilder.AlterColumn<string>(
                name: "Size",
                schema: "Warehouse",
                table: "StockItems",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(21)",
                oldMaxLength: 21,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                schema: "Warehouse",
                table: "StockItems",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(51)",
                oldMaxLength: 51,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Barcode",
                schema: "Warehouse",
                table: "StockItems",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(51)",
                oldMaxLength: 51,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BinLocation",
                schema: "Warehouse",
                table: "StockItemHoldings",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(21)",
                oldMaxLength: 21);

            migrationBuilder.AlterColumn<string>(
                name: "StockGroupName",
                schema: "Warehouse",
                table: "StockGroups",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(51)",
                oldMaxLength: 51);

            migrationBuilder.AlterColumn<string>(
                name: "StateProvinceName",
                schema: "Application",
                table: "StateProvinces",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(51)",
                oldMaxLength: 51);

            migrationBuilder.AlterColumn<string>(
                name: "StateProvinceCode",
                schema: "Application",
                table: "StateProvinces",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6);

            migrationBuilder.AlterColumn<string>(
                name: "SalesTerritory",
                schema: "Application",
                table: "StateProvinces",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(51)",
                oldMaxLength: 51);

            migrationBuilder.AlterColumn<string>(
                name: "DealDescription",
                schema: "Sales",
                table: "SpecialDeals",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(31)",
                oldMaxLength: 31);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierReference",
                schema: "Purchasing",
                table: "PurchaseOrders",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(21)",
                oldMaxLength: 21,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Purchasing",
                table: "PurchaseOrderLines",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(101)",
                oldMaxLength: 101);

            migrationBuilder.AlterColumn<string>(
                name: "PreferredName",
                schema: "Application",
                table: "People",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(51)",
                oldMaxLength: 51);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "Application",
                table: "People",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(21)",
                oldMaxLength: 21,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LogonName",
                schema: "Application",
                table: "People",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(51)",
                oldMaxLength: 51,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                schema: "Application",
                table: "People",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(51)",
                oldMaxLength: 51);

            migrationBuilder.AlterColumn<string>(
                name: "FaxNumber",
                schema: "Application",
                table: "People",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(21)",
                oldMaxLength: 21,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                schema: "Application",
                table: "People",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(257)",
                oldMaxLength: 257,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PaymentMethodName",
                schema: "Application",
                table: "PaymentMethods",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(51)",
                oldMaxLength: 51);

            migrationBuilder.AlterColumn<string>(
                name: "PackageTypeName",
                schema: "Warehouse",
                table: "PackageTypes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(51)",
                oldMaxLength: 51);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerPurchaseOrderNumber",
                schema: "Sales",
                table: "Orders",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(21)",
                oldMaxLength: 21,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Sales",
                table: "OrderLines",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(101)",
                oldMaxLength: 101);

            migrationBuilder.AlterColumn<string>(
                name: "RunPosition",
                schema: "Sales",
                table: "Invoices",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryRun",
                schema: "Sales",
                table: "Invoices",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerPurchaseOrderNumber",
                schema: "Sales",
                table: "Invoices",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(21)",
                oldMaxLength: 21,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Sales",
                table: "InvoiceLines",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(101)",
                oldMaxLength: 101);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryMethodName",
                schema: "Application",
                table: "DeliveryMethods",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(51)",
                oldMaxLength: 51);

            migrationBuilder.AlterColumn<string>(
                name: "WebsiteURL",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(257)",
                oldMaxLength: 257);

            migrationBuilder.AlterColumn<string>(
                name: "RunPosition",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalPostalCode",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine2",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(61)",
                oldMaxLength: 61,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine1",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(61)",
                oldMaxLength: 61);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(21)",
                oldMaxLength: 21);

            migrationBuilder.AlterColumn<string>(
                name: "FaxNumber",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(21)",
                oldMaxLength: 21);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryRun",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryPostalCode",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine2",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(61)",
                oldMaxLength: 61,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine1",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(61)",
                oldMaxLength: 61);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(101)",
                oldMaxLength: 101);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerCategoryName",
                schema: "Sales",
                table: "CustomerCategories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(51)",
                oldMaxLength: 51);

            migrationBuilder.AlterColumn<string>(
                name: "Subregion",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(31)",
                oldMaxLength: 31);

            migrationBuilder.AlterColumn<string>(
                name: "Region",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(31)",
                oldMaxLength: 31);

            migrationBuilder.AlterColumn<string>(
                name: "IsoAlpha3Code",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FormalName",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(61)",
                oldMaxLength: 61);

            migrationBuilder.AlterColumn<string>(
                name: "CountryType",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(21)",
                oldMaxLength: 21,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CountryName",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(61)",
                oldMaxLength: 61);

            migrationBuilder.AlterColumn<string>(
                name: "Continent",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(31)",
                oldMaxLength: 31);

            migrationBuilder.AlterColumn<string>(
                name: "ColorName",
                schema: "Warehouse",
                table: "Colors",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(21)",
                oldMaxLength: 21);

            migrationBuilder.AlterColumn<string>(
                name: "BuyingGroupName",
                schema: "Sales",
                table: "BuyingGroups",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(51)",
                oldMaxLength: 51);
        }
    }
}
