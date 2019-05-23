namespace Inevtory2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateEquipmentTable : DbMigration
    {
        public override void Up()
        {
			Sql("INSERT INTO EQUIPMENTS(euipmentname)VALUES('Desktop')");
			Sql("INSERT INTO EQUIPMENTS(euipmentname)VALUES('CPU')");
			Sql("INSERT INTO EQUIPMENTS(euipmentname)VALUES('Keyboard')");
			Sql("INSERT INTO EQUIPMENTS(euipmentname)VALUES('UPS')");
			Sql("INSERT INTO EQUIPMENTS(euipmentname)VALUES('Laptop')");
			Sql("INSERT INTO EQUIPMENTS(euipmentname)VALUES('Printer')");
		}
		public override void Down()
		{
			Sql("DELETE FROM EQUIPMENTS WHERE Id IN(1,2,3,4,5,6)");
		}
	}	
}
