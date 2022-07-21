using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfrastructureLayer.Migrations
{
    public partial class batch6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VehicleRegistration",
                schema: "Warehouse",
                table: "VehicleTemperatures",
                type: "nvarchar(26)",
                maxLength: 26,
                nullable: false,
                collation: "Latin1_General_CI_AS",
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldCollation: "Latin1_General_CI_AS");

            migrationBuilder.AlterColumn<string>(
                name: "FullSensorData",
                schema: "Warehouse",
                table: "VehicleTemperatures",
                type: "nvarchar(1006)",
                maxLength: 1006,
                nullable: true,
                collation: "Latin1_General_CI_AS",
                oldClrType: typeof(string),
                oldType: "nvarchar(1005)",
                oldMaxLength: 1005,
                oldNullable: true,
                oldCollation: "Latin1_General_CI_AS");

            migrationBuilder.AlterColumn<string>(
                name: "TransactionTypeName",
                schema: "Application",
                table: "TransactionTypes",
                type: "nvarchar(56)",
                maxLength: 56,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(55)",
                oldMaxLength: 55);

            migrationBuilder.AlterColumn<string>(
                name: "PostalPostalCode",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine2",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(66)",
                maxLength: 66,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(65)",
                oldMaxLength: 65,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine1",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(66)",
                maxLength: 66,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(65)",
                oldMaxLength: 65);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryPostalCode",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine2",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(66)",
                maxLength: 66,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(65)",
                oldMaxLength: 65,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine1",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(66)",
                maxLength: 66,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(65)",
                oldMaxLength: 65);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierInvoiceNumber",
                schema: "Purchasing",
                table: "SupplierTransactions",
                type: "nvarchar(26)",
                maxLength: 26,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WebsiteURL",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(262)",
                maxLength: 262,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(261)",
                oldMaxLength: 261);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierReference",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(26)",
                maxLength: 26,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierName",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(106)",
                maxLength: 106,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(105)",
                oldMaxLength: 105);

            migrationBuilder.AlterColumn<string>(
                name: "PostalPostalCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine2",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(66)",
                maxLength: 66,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(65)",
                oldMaxLength: 65,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine1",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(66)",
                maxLength: 66,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(65)",
                oldMaxLength: 65);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(26)",
                maxLength: 26,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "FaxNumber",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(26)",
                maxLength: 26,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryPostalCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine2",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(66)",
                maxLength: 66,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(65)",
                oldMaxLength: 65,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine1",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(66)",
                maxLength: 66,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(65)",
                oldMaxLength: 65);

            migrationBuilder.AlterColumn<string>(
                name: "BankInternationalCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(26)",
                maxLength: 26,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountNumber",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(26)",
                maxLength: 26,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountName",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(56)",
                maxLength: 56,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(55)",
                oldMaxLength: 55,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(26)",
                maxLength: 26,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountBranch",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(56)",
                maxLength: 56,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(55)",
                oldMaxLength: 55,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierCategoryName",
                schema: "Purchasing",
                table: "SupplierCategories",
                type: "nvarchar(56)",
                maxLength: 56,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(55)",
                oldMaxLength: 55);

            migrationBuilder.AlterColumn<string>(
                name: "StockItemName",
                schema: "Warehouse",
                table: "StockItems",
                type: "nvarchar(106)",
                maxLength: 106,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(105)",
                oldMaxLength: 105);

            migrationBuilder.AlterColumn<string>(
                name: "Size",
                schema: "Warehouse",
                table: "StockItems",
                type: "nvarchar(26)",
                maxLength: 26,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                schema: "Warehouse",
                table: "StockItems",
                type: "nvarchar(56)",
                maxLength: 56,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(55)",
                oldMaxLength: 55,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Barcode",
                schema: "Warehouse",
                table: "StockItems",
                type: "nvarchar(56)",
                maxLength: 56,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(55)",
                oldMaxLength: 55,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BinLocation",
                schema: "Warehouse",
                table: "StockItemHoldings",
                type: "nvarchar(26)",
                maxLength: 26,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "StockGroupName",
                schema: "Warehouse",
                table: "StockGroups",
                type: "nvarchar(56)",
                maxLength: 56,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(55)",
                oldMaxLength: 55);

            migrationBuilder.AlterColumn<string>(
                name: "StateProvinceName",
                schema: "Application",
                table: "StateProvinces",
                type: "nvarchar(56)",
                maxLength: 56,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(55)",
                oldMaxLength: 55);

            migrationBuilder.AlterColumn<string>(
                name: "StateProvinceCode",
                schema: "Application",
                table: "StateProvinces",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9);

            migrationBuilder.AlterColumn<string>(
                name: "SalesTerritory",
                schema: "Application",
                table: "StateProvinces",
                type: "nvarchar(56)",
                maxLength: 56,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(55)",
                oldMaxLength: 55);

            migrationBuilder.AlterColumn<string>(
                name: "DealDescription",
                schema: "Sales",
                table: "SpecialDeals",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierReference",
                schema: "Purchasing",
                table: "PurchaseOrders",
                type: "nvarchar(26)",
                maxLength: 26,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Purchasing",
                table: "PurchaseOrderLines",
                type: "nvarchar(106)",
                maxLength: 106,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(105)",
                oldMaxLength: 105);

            migrationBuilder.AlterColumn<string>(
                name: "PreferredName",
                schema: "Application",
                table: "People",
                type: "nvarchar(56)",
                maxLength: 56,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(55)",
                oldMaxLength: 55);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "Application",
                table: "People",
                type: "nvarchar(26)",
                maxLength: 26,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LogonName",
                schema: "Application",
                table: "People",
                type: "nvarchar(56)",
                maxLength: 56,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(55)",
                oldMaxLength: 55,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                schema: "Application",
                table: "People",
                type: "nvarchar(56)",
                maxLength: 56,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(55)",
                oldMaxLength: 55);

            migrationBuilder.AlterColumn<string>(
                name: "FaxNumber",
                schema: "Application",
                table: "People",
                type: "nvarchar(26)",
                maxLength: 26,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                schema: "Application",
                table: "People",
                type: "nvarchar(262)",
                maxLength: 262,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(261)",
                oldMaxLength: 261,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PaymentMethodName",
                schema: "Application",
                table: "PaymentMethods",
                type: "nvarchar(56)",
                maxLength: 56,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(55)",
                oldMaxLength: 55);

            migrationBuilder.AlterColumn<string>(
                name: "PackageTypeName",
                schema: "Warehouse",
                table: "PackageTypes",
                type: "nvarchar(56)",
                maxLength: 56,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(55)",
                oldMaxLength: 55);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerPurchaseOrderNumber",
                schema: "Sales",
                table: "Orders",
                type: "nvarchar(26)",
                maxLength: 26,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Sales",
                table: "OrderLines",
                type: "nvarchar(106)",
                maxLength: 106,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(105)",
                oldMaxLength: 105);

            migrationBuilder.AlterColumn<string>(
                name: "RunPosition",
                schema: "Sales",
                table: "Invoices",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryRun",
                schema: "Sales",
                table: "Invoices",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerPurchaseOrderNumber",
                schema: "Sales",
                table: "Invoices",
                type: "nvarchar(26)",
                maxLength: 26,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Sales",
                table: "InvoiceLines",
                type: "nvarchar(106)",
                maxLength: 106,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(105)",
                oldMaxLength: 105);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryMethodName",
                schema: "Application",
                table: "DeliveryMethods",
                type: "nvarchar(56)",
                maxLength: 56,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(55)",
                oldMaxLength: 55);

            migrationBuilder.AlterColumn<string>(
                name: "WebsiteURL",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(262)",
                maxLength: 262,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(261)",
                oldMaxLength: 261);

            migrationBuilder.AlterColumn<string>(
                name: "RunPosition",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalPostalCode",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine2",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(66)",
                maxLength: 66,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(65)",
                oldMaxLength: 65,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine1",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(66)",
                maxLength: 66,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(65)",
                oldMaxLength: 65);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(26)",
                maxLength: 26,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "FaxNumber",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(26)",
                maxLength: 26,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryRun",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryPostalCode",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine2",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(66)",
                maxLength: 66,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(65)",
                oldMaxLength: 65,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine1",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(66)",
                maxLength: 66,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(65)",
                oldMaxLength: 65);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(106)",
                maxLength: 106,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(105)",
                oldMaxLength: 105);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerCategoryName",
                schema: "Sales",
                table: "CustomerCategories",
                type: "nvarchar(56)",
                maxLength: 56,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(55)",
                oldMaxLength: 55);

            migrationBuilder.AlterColumn<string>(
                name: "Subregion",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);

            migrationBuilder.AlterColumn<string>(
                name: "Region",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);

            migrationBuilder.AlterColumn<string>(
                name: "IsoAlpha3Code",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FormalName",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(66)",
                maxLength: 66,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(65)",
                oldMaxLength: 65);

            migrationBuilder.AlterColumn<string>(
                name: "CountryType",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(26)",
                maxLength: 26,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CountryName",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(66)",
                maxLength: 66,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(65)",
                oldMaxLength: 65);

            migrationBuilder.AlterColumn<string>(
                name: "Continent",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);

            migrationBuilder.AlterColumn<string>(
                name: "ColorName",
                schema: "Warehouse",
                table: "Colors",
                type: "nvarchar(26)",
                maxLength: 26,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "CityName",
                schema: "Application",
                table: "Cities",
                type: "nvarchar(56)",
                maxLength: 56,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(55)",
                oldMaxLength: 55);

            migrationBuilder.AlterColumn<string>(
                name: "BuyingGroupName",
                schema: "Sales",
                table: "BuyingGroups",
                type: "nvarchar(56)",
                maxLength: 56,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(55)",
                oldMaxLength: 55);

            migrationBuilder.AlterColumn<string>(
                name: "SearchName",
                schema: "Application",
                table: "People",
                type: "nvarchar(106)",
                maxLength: 106,
                nullable: false,
                computedColumnSql: "(concat([PreferredName],N' ',[FullName]))",
                stored: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(105)",
                oldMaxLength: 105,
                oldComputedColumnSql: "(concat([PreferredName],N' ',[FullName]))",
                oldStored: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VehicleRegistration",
                schema: "Warehouse",
                table: "VehicleTemperatures",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                collation: "Latin1_General_CI_AS",
                oldClrType: typeof(string),
                oldType: "nvarchar(26)",
                oldMaxLength: 26,
                oldCollation: "Latin1_General_CI_AS");

            migrationBuilder.AlterColumn<string>(
                name: "FullSensorData",
                schema: "Warehouse",
                table: "VehicleTemperatures",
                type: "nvarchar(1005)",
                maxLength: 1005,
                nullable: true,
                collation: "Latin1_General_CI_AS",
                oldClrType: typeof(string),
                oldType: "nvarchar(1006)",
                oldMaxLength: 1006,
                oldNullable: true,
                oldCollation: "Latin1_General_CI_AS");

            migrationBuilder.AlterColumn<string>(
                name: "TransactionTypeName",
                schema: "Application",
                table: "TransactionTypes",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(56)",
                oldMaxLength: 56);

            migrationBuilder.AlterColumn<string>(
                name: "PostalPostalCode",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldMaxLength: 16);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine2",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(65)",
                maxLength: 65,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(66)",
                oldMaxLength: 66,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine1",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(65)",
                maxLength: 65,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(66)",
                oldMaxLength: 66);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryPostalCode",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldMaxLength: 16);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine2",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(65)",
                maxLength: 65,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(66)",
                oldMaxLength: 66,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine1",
                schema: "Application",
                table: "SystemParameters",
                type: "nvarchar(65)",
                maxLength: 65,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(66)",
                oldMaxLength: 66);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierInvoiceNumber",
                schema: "Purchasing",
                table: "SupplierTransactions",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(26)",
                oldMaxLength: 26,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WebsiteURL",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(261)",
                maxLength: 261,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(262)",
                oldMaxLength: 262);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierReference",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(26)",
                oldMaxLength: 26,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierName",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(105)",
                maxLength: 105,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(106)",
                oldMaxLength: 106);

            migrationBuilder.AlterColumn<string>(
                name: "PostalPostalCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldMaxLength: 16);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine2",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(65)",
                maxLength: 65,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(66)",
                oldMaxLength: 66,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine1",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(65)",
                maxLength: 65,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(66)",
                oldMaxLength: 66);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(26)",
                oldMaxLength: 26);

            migrationBuilder.AlterColumn<string>(
                name: "FaxNumber",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(26)",
                oldMaxLength: 26);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryPostalCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldMaxLength: 16);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine2",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(65)",
                maxLength: 65,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(66)",
                oldMaxLength: 66,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine1",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(65)",
                maxLength: 65,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(66)",
                oldMaxLength: 66);

            migrationBuilder.AlterColumn<string>(
                name: "BankInternationalCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(26)",
                oldMaxLength: 26,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountNumber",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(26)",
                oldMaxLength: 26,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountName",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(56)",
                oldMaxLength: 56,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountCode",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(26)",
                oldMaxLength: 26,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankAccountBranch",
                schema: "Purchasing",
                table: "Suppliers",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(56)",
                oldMaxLength: 56,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierCategoryName",
                schema: "Purchasing",
                table: "SupplierCategories",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(56)",
                oldMaxLength: 56);

            migrationBuilder.AlterColumn<string>(
                name: "StockItemName",
                schema: "Warehouse",
                table: "StockItems",
                type: "nvarchar(105)",
                maxLength: 105,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(106)",
                oldMaxLength: 106);

            migrationBuilder.AlterColumn<string>(
                name: "Size",
                schema: "Warehouse",
                table: "StockItems",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(26)",
                oldMaxLength: 26,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                schema: "Warehouse",
                table: "StockItems",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(56)",
                oldMaxLength: 56,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Barcode",
                schema: "Warehouse",
                table: "StockItems",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(56)",
                oldMaxLength: 56,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BinLocation",
                schema: "Warehouse",
                table: "StockItemHoldings",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(26)",
                oldMaxLength: 26);

            migrationBuilder.AlterColumn<string>(
                name: "StockGroupName",
                schema: "Warehouse",
                table: "StockGroups",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(56)",
                oldMaxLength: 56);

            migrationBuilder.AlterColumn<string>(
                name: "StateProvinceName",
                schema: "Application",
                table: "StateProvinces",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(56)",
                oldMaxLength: 56);

            migrationBuilder.AlterColumn<string>(
                name: "StateProvinceCode",
                schema: "Application",
                table: "StateProvinces",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "SalesTerritory",
                schema: "Application",
                table: "StateProvinces",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(56)",
                oldMaxLength: 56);

            migrationBuilder.AlterColumn<string>(
                name: "DealDescription",
                schema: "Sales",
                table: "SpecialDeals",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(36)",
                oldMaxLength: 36);

            migrationBuilder.AlterColumn<string>(
                name: "SupplierReference",
                schema: "Purchasing",
                table: "PurchaseOrders",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(26)",
                oldMaxLength: 26,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Purchasing",
                table: "PurchaseOrderLines",
                type: "nvarchar(105)",
                maxLength: 105,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(106)",
                oldMaxLength: 106);

            migrationBuilder.AlterColumn<string>(
                name: "PreferredName",
                schema: "Application",
                table: "People",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(56)",
                oldMaxLength: 56);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "Application",
                table: "People",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(26)",
                oldMaxLength: 26,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LogonName",
                schema: "Application",
                table: "People",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(56)",
                oldMaxLength: 56,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                schema: "Application",
                table: "People",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(56)",
                oldMaxLength: 56);

            migrationBuilder.AlterColumn<string>(
                name: "FaxNumber",
                schema: "Application",
                table: "People",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(26)",
                oldMaxLength: 26,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                schema: "Application",
                table: "People",
                type: "nvarchar(261)",
                maxLength: 261,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(262)",
                oldMaxLength: 262,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PaymentMethodName",
                schema: "Application",
                table: "PaymentMethods",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(56)",
                oldMaxLength: 56);

            migrationBuilder.AlterColumn<string>(
                name: "PackageTypeName",
                schema: "Warehouse",
                table: "PackageTypes",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(56)",
                oldMaxLength: 56);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerPurchaseOrderNumber",
                schema: "Sales",
                table: "Orders",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(26)",
                oldMaxLength: 26,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Sales",
                table: "OrderLines",
                type: "nvarchar(105)",
                maxLength: 105,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(106)",
                oldMaxLength: 106);

            migrationBuilder.AlterColumn<string>(
                name: "RunPosition",
                schema: "Sales",
                table: "Invoices",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryRun",
                schema: "Sales",
                table: "Invoices",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerPurchaseOrderNumber",
                schema: "Sales",
                table: "Invoices",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(26)",
                oldMaxLength: 26,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Sales",
                table: "InvoiceLines",
                type: "nvarchar(105)",
                maxLength: 105,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(106)",
                oldMaxLength: 106);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryMethodName",
                schema: "Application",
                table: "DeliveryMethods",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(56)",
                oldMaxLength: 56);

            migrationBuilder.AlterColumn<string>(
                name: "WebsiteURL",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(261)",
                maxLength: 261,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(262)",
                oldMaxLength: 262);

            migrationBuilder.AlterColumn<string>(
                name: "RunPosition",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalPostalCode",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldMaxLength: 16);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine2",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(65)",
                maxLength: 65,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(66)",
                oldMaxLength: 66,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddressLine1",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(65)",
                maxLength: 65,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(66)",
                oldMaxLength: 66);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(26)",
                oldMaxLength: 26);

            migrationBuilder.AlterColumn<string>(
                name: "FaxNumber",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(26)",
                oldMaxLength: 26);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryRun",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryPostalCode",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldMaxLength: 16);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine2",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(65)",
                maxLength: 65,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(66)",
                oldMaxLength: 66,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryAddressLine1",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(65)",
                maxLength: 65,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(66)",
                oldMaxLength: 66);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                schema: "Sales",
                table: "Customers",
                type: "nvarchar(105)",
                maxLength: 105,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(106)",
                oldMaxLength: 106);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerCategoryName",
                schema: "Sales",
                table: "CustomerCategories",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(56)",
                oldMaxLength: 56);

            migrationBuilder.AlterColumn<string>(
                name: "Subregion",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(36)",
                oldMaxLength: 36);

            migrationBuilder.AlterColumn<string>(
                name: "Region",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(36)",
                oldMaxLength: 36);

            migrationBuilder.AlterColumn<string>(
                name: "IsoAlpha3Code",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FormalName",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(65)",
                maxLength: 65,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(66)",
                oldMaxLength: 66);

            migrationBuilder.AlterColumn<string>(
                name: "CountryType",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(26)",
                oldMaxLength: 26,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CountryName",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(65)",
                maxLength: 65,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(66)",
                oldMaxLength: 66);

            migrationBuilder.AlterColumn<string>(
                name: "Continent",
                schema: "Application",
                table: "Countries",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(36)",
                oldMaxLength: 36);

            migrationBuilder.AlterColumn<string>(
                name: "ColorName",
                schema: "Warehouse",
                table: "Colors",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(26)",
                oldMaxLength: 26);

            migrationBuilder.AlterColumn<string>(
                name: "CityName",
                schema: "Application",
                table: "Cities",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(56)",
                oldMaxLength: 56);

            migrationBuilder.AlterColumn<string>(
                name: "BuyingGroupName",
                schema: "Sales",
                table: "BuyingGroups",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(56)",
                oldMaxLength: 56);

            migrationBuilder.AlterColumn<string>(
                name: "SearchName",
                schema: "Application",
                table: "People",
                type: "nvarchar(105)",
                maxLength: 105,
                nullable: false,
                computedColumnSql: "(concat([PreferredName],N' ',[FullName]))",
                stored: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(106)",
                oldMaxLength: 106,
                oldComputedColumnSql: "(concat([PreferredName],N' ',[FullName]))",
                oldStored: true);
        }
    }
}
