using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfrastructureLayer.Migrations
{
    public partial class batch4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VehicleRegistration",
                schema: "Warehouse",
                table: "VehicleTemperatures",
                type: "nvarchar(24)",
                maxLength: 24,
                nullable: false,
                collation: "Latin1_General_CI_AS",
                oldClrType: typeof(string),
                oldType: "nvarchar(23)",
                oldMaxLength: 23,
                oldCollation: "Latin1_General_CI_AS");

            migrationBuilder.AlterColumn<string>(
                name: "FullSensorData",
                schema: "Warehouse",
                table: "VehicleTemperatures",
                type: "nvarchar(1004)",
                maxLength: 1004,
                nullable: true,
                collation: "Latin1_General_CI_AS",
                oldClrType: typeof(string),
                oldType: "nvarchar(1003)",
                oldMaxLength: 1003,
                oldNullable: true,
                oldCollation: "Latin1_General_CI_AS");

            migrationBuilder.AlterColumn<string>(
                name: "TransactionTypeName",
                schema: "Application",
                table: "TransactionTypes",
                type: "nvarchar(54)",
                maxLength: 54,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(53)",
                oldMaxLength: 53);

            migrationBuilder.AlterColumn<string>(
                name: "PostalPostalCode",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(13)",
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine2",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(63)",
                oldMaxLength: 63,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine1",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(63)",
                oldMaxLength: 63);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryPostalCode",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(13)",
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine2",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(63)",
                oldMaxLength: 63,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine1",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(63)",
                oldMaxLength: 63);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierInvoiceNumber",
                schema: "Purchasing",
                table: "SupplierTransactions",
                type: "nvarchar(24)",
                maxLength: 24,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(23)",
                oldMaxLength: 23,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WebsiteURL",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(260)",
                maxLength: 260,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(259)",
                oldMaxLength: 259);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierReference",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(24)",
                maxLength: 24,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(23)",
                oldMaxLength: 23,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierName",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(104)",
                maxLength: 104,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(103)",
                oldMaxLength: 103);

            migrationBuilder.AlterColumn<string>(
                name: "PostalPostalCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(13)",
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine2",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(63)",
                oldMaxLength: 63,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine1",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(63)",
                oldMaxLength: 63);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(24)",
                maxLength: 24,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(23)",
                oldMaxLength: 23);

            migrationBuilder.AlterColumn<string>(
                name: "FaxNumber",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(24)",
                maxLength: 24,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(23)",
                oldMaxLength: 23);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryPostalCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(13)",
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine2",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(63)",
                oldMaxLength: 63,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine1",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(63)",
                oldMaxLength: 63);

            migrationBuilder.AlterColumn<string>(
                name: "BankInternationalCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(24)",
                maxLength: 24,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(23)",
                oldMaxLength: 23,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountNumber",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(24)",
                maxLength: 24,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(23)",
                oldMaxLength: 23,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountName",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(54)",
                maxLength: 54,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(53)",
                oldMaxLength: 53,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(24)",
                maxLength: 24,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(23)",
                oldMaxLength: 23,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountBranch",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(54)",
                maxLength: 54,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(53)",
                oldMaxLength: 53,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierCategoryName",
                schema: "Purchasing",
                table: "SupplierCategories",
                type: "nvarchar(54)",
                maxLength: 54,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(53)",
                oldMaxLength: 53);

            migrationBuilder.AlterColumn<string>(
                name: "StockItemName",
                schema: "Warehouse",
                table: "StockItems",
                type: "nvarchar(104)",
                maxLength: 104,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(103)",
                oldMaxLength: 103);

            migrationBuilder.AlterColumn<string>(
                name: "Size",
                schema: "Warehouse",
                table: "StockItems",
                type: "nvarchar(24)",
                maxLength: 24,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(23)",
                oldMaxLength: 23,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                schema: "Warehouse",
                table: "StockItems",
                type: "nvarchar(54)",
                maxLength: 54,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(53)",
                oldMaxLength: 53,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Barcode",
                schema: "Warehouse",
                table: "StockItems",
                type: "nvarchar(54)",
                maxLength: 54,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(53)",
                oldMaxLength: 53,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BinLocation",
                schema: "Warehouse",
                table: "StockItemHoldings",
                type: "nvarchar(24)",
                maxLength: 24,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(23)",
                oldMaxLength: 23);

            migrationBuilder.AlterColumn<string>(
                name: "StockGroupName",
                schema: "Warehouse",
                table: "StockGroups",
                type: "nvarchar(54)",
                maxLength: 54,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(53)",
                oldMaxLength: 53);

            migrationBuilder.AlterColumn<string>(
                name: "StateProvinceName",
                schema: "Application",
                table: "StateProvinces",
                type: "nvarchar(54)",
                maxLength: 54,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(53)",
                oldMaxLength: 53);

            migrationBuilder.AlterColumn<string>(
                name: "StateProvinceCode",
                schema: "Application",
                table: "StateProvinces",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<string>(
                name: "SalesTerritory",
                schema: "Application",
                table: "StateProvinces",
                type: "nvarchar(54)",
                maxLength: 54,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(53)",
                oldMaxLength: 53);

            migrationBuilder.AlterColumn<string>(
                name: "DealDescription",
                schema: "Sales",
                table: "SpecialDeals",
                type: "nvarchar(34)",
                maxLength: 34,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(33)",
                oldMaxLength: 33);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierReference",
                schema: "Purchasing",
                table: "PurchaseOrders",
                type: "nvarchar(24)",
                maxLength: 24,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(23)",
                oldMaxLength: 23,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Purchasing",
                table: "PurchaseOrderLines",
                type: "nvarchar(104)",
                maxLength: 104,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(103)",
                oldMaxLength: 103);

            migrationBuilder.AlterColumn<string>(
                name: "PreferredName",
                schema: "Application",
                table: "People",
                type: "nvarchar(54)",
                maxLength: 54,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(53)",
                oldMaxLength: 53);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "Application",
                table: "People",
                type: "nvarchar(24)",
                maxLength: 24,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(23)",
                oldMaxLength: 23,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LogonName",
                schema: "Application",
                table: "People",
                type: "nvarchar(54)",
                maxLength: 54,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(53)",
                oldMaxLength: 53,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                schema: "Application",
                table: "People",
                type: "nvarchar(54)",
                maxLength: 54,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(53)",
                oldMaxLength: 53);

            migrationBuilder.AlterColumn<string>(
                name: "FaxNumber",
                schema: "Application",
                table: "People",
                type: "nvarchar(24)",
                maxLength: 24,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(23)",
                oldMaxLength: 23,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                schema: "Application",
                table: "People",
                type: "nvarchar(260)",
                maxLength: 260,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(259)",
                oldMaxLength: 259,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PaymentMethodName",
                schema: "Application",
                table: "PaymentMethods",
                type: "nvarchar(54)",
                maxLength: 54,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(53)",
                oldMaxLength: 53);

            migrationBuilder.AlterColumn<string>(
                name: "PackageTypeName",
                schema: "Warehouse",
                table: "PackageTypes",
                type: "nvarchar(54)",
                maxLength: 54,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(53)",
                oldMaxLength: 53);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerPurchaseOrderNumber",
                schema: "Sales",
                table: "Orders",
                type: "nvarchar(24)",
                maxLength: 24,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(23)",
                oldMaxLength: 23,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Sales",
                table: "OrderLines",
                type: "nvarchar(104)",
                maxLength: 104,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(103)",
                oldMaxLength: 103);

            migrationBuilder.AlterColumn<string>(
                name: "RunPosition",
                schema: "Sales",
                table: "Invoices",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryRun",
                schema: "Sales",
                table: "Invoices",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerPurchaseOrderNumber",
                schema: "Sales",
                table: "Invoices",
                type: "nvarchar(24)",
                maxLength: 24,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(23)",
                oldMaxLength: 23,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Sales",
                table: "InvoiceLines",
                type: "nvarchar(104)",
                maxLength: 104,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(103)",
                oldMaxLength: 103);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryMethodName",
                schema: "Application",
                table: "DeliveryMethods",
                type: "nvarchar(54)",
                maxLength: 54,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(53)",
                oldMaxLength: 53);

            migrationBuilder.AlterColumn<string>(
                name: "WebsiteURL",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(260)",
                maxLength: 260,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(259)",
                oldMaxLength: 259);

            migrationBuilder.AlterColumn<string>(
                name: "RunPosition",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalPostalCode",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(13)",
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine2",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(63)",
                oldMaxLength: 63,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine1",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(63)",
                oldMaxLength: 63);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(24)",
                maxLength: 24,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(23)",
                oldMaxLength: 23);

            migrationBuilder.AlterColumn<string>(
                name: "FaxNumber",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(24)",
                maxLength: 24,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(23)",
                oldMaxLength: 23);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryRun",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryPostalCode",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(13)",
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine2",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(63)",
                oldMaxLength: 63,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine1",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(63)",
                oldMaxLength: 63);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(104)",
                maxLength: 104,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(103)",
                oldMaxLength: 103);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerCategoryName",
                schema: "Sales",
                table: "CustomerCategories",
                type: "nvarchar(54)",
                maxLength: 54,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(53)",
                oldMaxLength: 53);

            migrationBuilder.AlterColumn<string>(
                name: "Subregion",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(34)",
                maxLength: 34,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(33)",
                oldMaxLength: 33);

            migrationBuilder.AlterColumn<string>(
                name: "Region",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(34)",
                maxLength: 34,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(33)",
                oldMaxLength: 33);

            migrationBuilder.AlterColumn<string>(
                name: "IsoAlpha3Code",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FormalName",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(63)",
                oldMaxLength: 63);

            migrationBuilder.AlterColumn<string>(
                name: "CountryType",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(24)",
                maxLength: 24,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(23)",
                oldMaxLength: 23,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CountryName",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(63)",
                oldMaxLength: 63);

            migrationBuilder.AlterColumn<string>(
                name: "Continent",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(34)",
                maxLength: 34,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(33)",
                oldMaxLength: 33);

            migrationBuilder.AlterColumn<string>(
                name: "ColorName",
                schema: "Warehouse",
                table: "Colors",
                type: "nvarchar(24)",
                maxLength: 24,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(23)",
                oldMaxLength: 23);

            migrationBuilder.AlterColumn<string>(
                name: "CityName",
                schema: "Application",
                table: "Cities",
                type: "nvarchar(54)",
                maxLength: 54,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(53)",
                oldMaxLength: 53);

            migrationBuilder.AlterColumn<string>(
                name: "BuyingGroupName",
                schema: "Sales",
                table: "BuyingGroups",
                type: "nvarchar(54)",
                maxLength: 54,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(53)",
                oldMaxLength: 53);

            migrationBuilder.AlterColumn<string>(
                name: "SearchName",
                schema: "Application",
                table: "People",
                type: "nvarchar(104)",
                maxLength: 104,
                nullable: false,
                computedColumnSql: "(concat([PreferredName],N' ',[FullName]))",
                stored: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(103)",
                oldMaxLength: 103,
                oldComputedColumnSql: "(concat([PreferredName],N' ',[FullName]))",
                oldStored: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VehicleRegistration",
                schema: "Warehouse",
                table: "VehicleTemperatures",
                type: "nvarchar(23)",
                maxLength: 23,
                nullable: false,
                collation: "Latin1_General_CI_AS",
                oldClrType: typeof(string),
                oldType: "nvarchar(24)",
                oldMaxLength: 24,
                oldCollation: "Latin1_General_CI_AS");

            migrationBuilder.AlterColumn<string>(
                name: "FullSensorData",
                schema: "Warehouse",
                table: "VehicleTemperatures",
                type: "nvarchar(1003)",
                maxLength: 1003,
                nullable: true,
                collation: "Latin1_General_CI_AS",
                oldClrType: typeof(string),
                oldType: "nvarchar(1004)",
                oldMaxLength: 1004,
                oldNullable: true,
                oldCollation: "Latin1_General_CI_AS");

            migrationBuilder.AlterColumn<string>(
                name: "TransactionTypeName",
                schema: "Application",
                table: "TransactionTypes",
                type: "nvarchar(53)",
                maxLength: 53,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(54)",
                oldMaxLength: 54);

            migrationBuilder.AlterColumn<string>(
                name: "PostalPostalCode",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine2",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(63)",
                maxLength: 63,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine1",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(63)",
                maxLength: 63,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryPostalCode",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine2",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(63)",
                maxLength: 63,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine1",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(63)",
                maxLength: 63,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierInvoiceNumber",
                schema: "Purchasing",
                table: "SupplierTransactions",
                type: "nvarchar(23)",
                maxLength: 23,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(24)",
                oldMaxLength: 24,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WebsiteURL",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(259)",
                maxLength: 259,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(260)",
                oldMaxLength: 260);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierReference",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(23)",
                maxLength: 23,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(24)",
                oldMaxLength: 24,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierName",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(103)",
                maxLength: 103,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(104)",
                oldMaxLength: 104);

            migrationBuilder.AlterColumn<string>(
                name: "PostalPostalCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine2",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(63)",
                maxLength: 63,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine1",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(63)",
                maxLength: 63,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(23)",
                maxLength: 23,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(24)",
                oldMaxLength: 24);

            migrationBuilder.AlterColumn<string>(
                name: "FaxNumber",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(23)",
                maxLength: 23,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(24)",
                oldMaxLength: 24);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryPostalCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine2",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(63)",
                maxLength: 63,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine1",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(63)",
                maxLength: 63,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "BankInternationalCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(23)",
                maxLength: 23,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(24)",
                oldMaxLength: 24,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountNumber",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(23)",
                maxLength: 23,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(24)",
                oldMaxLength: 24,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountName",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(53)",
                maxLength: 53,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(54)",
                oldMaxLength: 54,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(23)",
                maxLength: 23,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(24)",
                oldMaxLength: 24,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountBranch",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(53)",
                maxLength: 53,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(54)",
                oldMaxLength: 54,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierCategoryName",
                schema: "Purchasing",
                table: "SupplierCategories",
                type: "nvarchar(53)",
                maxLength: 53,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(54)",
                oldMaxLength: 54);

            migrationBuilder.AlterColumn<string>(
                name: "StockItemName",
                schema: "Warehouse",
                table: "StockItems",
                type: "nvarchar(103)",
                maxLength: 103,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(104)",
                oldMaxLength: 104);

            migrationBuilder.AlterColumn<string>(
                name: "Size",
                schema: "Warehouse",
                table: "StockItems",
                type: "nvarchar(23)",
                maxLength: 23,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(24)",
                oldMaxLength: 24,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                schema: "Warehouse",
                table: "StockItems",
                type: "nvarchar(53)",
                maxLength: 53,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(54)",
                oldMaxLength: 54,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Barcode",
                schema: "Warehouse",
                table: "StockItems",
                type: "nvarchar(53)",
                maxLength: 53,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(54)",
                oldMaxLength: 54,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BinLocation",
                schema: "Warehouse",
                table: "StockItemHoldings",
                type: "nvarchar(23)",
                maxLength: 23,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(24)",
                oldMaxLength: 24);

            migrationBuilder.AlterColumn<string>(
                name: "StockGroupName",
                schema: "Warehouse",
                table: "StockGroups",
                type: "nvarchar(53)",
                maxLength: 53,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(54)",
                oldMaxLength: 54);

            migrationBuilder.AlterColumn<string>(
                name: "StateProvinceName",
                schema: "Application",
                table: "StateProvinces",
                type: "nvarchar(53)",
                maxLength: 53,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(54)",
                oldMaxLength: 54);

            migrationBuilder.AlterColumn<string>(
                name: "StateProvinceCode",
                schema: "Application",
                table: "StateProvinces",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9);

            migrationBuilder.AlterColumn<string>(
                name: "SalesTerritory",
                schema: "Application",
                table: "StateProvinces",
                type: "nvarchar(53)",
                maxLength: 53,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(54)",
                oldMaxLength: 54);

            migrationBuilder.AlterColumn<string>(
                name: "DealDescription",
                schema: "Sales",
                table: "SpecialDeals",
                type: "nvarchar(33)",
                maxLength: 33,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(34)",
                oldMaxLength: 34);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierReference",
                schema: "Purchasing",
                table: "PurchaseOrders",
                type: "nvarchar(23)",
                maxLength: 23,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(24)",
                oldMaxLength: 24,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Purchasing",
                table: "PurchaseOrderLines",
                type: "nvarchar(103)",
                maxLength: 103,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(104)",
                oldMaxLength: 104);

            migrationBuilder.AlterColumn<string>(
                name: "PreferredName",
                schema: "Application",
                table: "People",
                type: "nvarchar(53)",
                maxLength: 53,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(54)",
                oldMaxLength: 54);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "Application",
                table: "People",
                type: "nvarchar(23)",
                maxLength: 23,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(24)",
                oldMaxLength: 24,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LogonName",
                schema: "Application",
                table: "People",
                type: "nvarchar(53)",
                maxLength: 53,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(54)",
                oldMaxLength: 54,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                schema: "Application",
                table: "People",
                type: "nvarchar(53)",
                maxLength: 53,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(54)",
                oldMaxLength: 54);

            migrationBuilder.AlterColumn<string>(
                name: "FaxNumber",
                schema: "Application",
                table: "People",
                type: "nvarchar(23)",
                maxLength: 23,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(24)",
                oldMaxLength: 24,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                schema: "Application",
                table: "People",
                type: "nvarchar(259)",
                maxLength: 259,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(260)",
                oldMaxLength: 260,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PaymentMethodName",
                schema: "Application",
                table: "PaymentMethods",
                type: "nvarchar(53)",
                maxLength: 53,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(54)",
                oldMaxLength: 54);

            migrationBuilder.AlterColumn<string>(
                name: "PackageTypeName",
                schema: "Warehouse",
                table: "PackageTypes",
                type: "nvarchar(53)",
                maxLength: 53,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(54)",
                oldMaxLength: 54);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerPurchaseOrderNumber",
                schema: "Sales",
                table: "Orders",
                type: "nvarchar(23)",
                maxLength: 23,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(24)",
                oldMaxLength: 24,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Sales",
                table: "OrderLines",
                type: "nvarchar(103)",
                maxLength: 103,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(104)",
                oldMaxLength: 104);

            migrationBuilder.AlterColumn<string>(
                name: "RunPosition",
                schema: "Sales",
                table: "Invoices",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryRun",
                schema: "Sales",
                table: "Invoices",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerPurchaseOrderNumber",
                schema: "Sales",
                table: "Invoices",
                type: "nvarchar(23)",
                maxLength: 23,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(24)",
                oldMaxLength: 24,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Sales",
                table: "InvoiceLines",
                type: "nvarchar(103)",
                maxLength: 103,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(104)",
                oldMaxLength: 104);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryMethodName",
                schema: "Application",
                table: "DeliveryMethods",
                type: "nvarchar(53)",
                maxLength: 53,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(54)",
                oldMaxLength: 54);

            migrationBuilder.AlterColumn<string>(
                name: "WebsiteURL",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(259)",
                maxLength: 259,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(260)",
                oldMaxLength: 260);

            migrationBuilder.AlterColumn<string>(
                name: "RunPosition",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalPostalCode",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine2",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(63)",
                maxLength: 63,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine1",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(63)",
                maxLength: 63,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(23)",
                maxLength: 23,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(24)",
                oldMaxLength: 24);

            migrationBuilder.AlterColumn<string>(
                name: "FaxNumber",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(23)",
                maxLength: 23,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(24)",
                oldMaxLength: 24);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryRun",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryPostalCode",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine2",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(63)",
                maxLength: 63,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine1",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(63)",
                maxLength: 63,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(103)",
                maxLength: 103,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(104)",
                oldMaxLength: 104);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerCategoryName",
                schema: "Sales",
                table: "CustomerCategories",
                type: "nvarchar(53)",
                maxLength: 53,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(54)",
                oldMaxLength: 54);

            migrationBuilder.AlterColumn<string>(
                name: "Subregion",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(33)",
                maxLength: 33,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(34)",
                oldMaxLength: 34);

            migrationBuilder.AlterColumn<string>(
                name: "Region",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(33)",
                maxLength: 33,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(34)",
                oldMaxLength: 34);

            migrationBuilder.AlterColumn<string>(
                name: "IsoAlpha3Code",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FormalName",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(63)",
                maxLength: 63,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "CountryType",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(23)",
                maxLength: 23,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(24)",
                oldMaxLength: 24,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CountryName",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(63)",
                maxLength: 63,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "Continent",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(33)",
                maxLength: 33,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(34)",
                oldMaxLength: 34);

            migrationBuilder.AlterColumn<string>(
                name: "ColorName",
                schema: "Warehouse",
                table: "Colors",
                type: "nvarchar(23)",
                maxLength: 23,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(24)",
                oldMaxLength: 24);

            migrationBuilder.AlterColumn<string>(
                name: "CityName",
                schema: "Application",
                table: "Cities",
                type: "nvarchar(53)",
                maxLength: 53,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(54)",
                oldMaxLength: 54);

            migrationBuilder.AlterColumn<string>(
                name: "BuyingGroupName",
                schema: "Sales",
                table: "BuyingGroups",
                type: "nvarchar(53)",
                maxLength: 53,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(54)",
                oldMaxLength: 54);

            migrationBuilder.AlterColumn<string>(
                name: "SearchName",
                schema: "Application",
                table: "People",
                type: "nvarchar(103)",
                maxLength: 103,
                nullable: false,
                computedColumnSql: "(concat([PreferredName],N' ',[FullName]))",
                stored: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(104)",
                oldMaxLength: 104,
                oldComputedColumnSql: "(concat([PreferredName],N' ',[FullName]))",
                oldStored: true);
        }
    }
}
