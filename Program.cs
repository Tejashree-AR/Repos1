using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
/*To access a database, we need to open a connection to it first and close it once our job is done.
				Connecting to a database depends on the type of the target database and the database management system (DBMS). For example, connecting to a SQL Server database is different from connecting to an Oracle database. But both these connections have a few things in common:
			
				• They have a connection string
				• They can be opened
				• They can be closed
				• They may have a timeout attribute (so if the connection could not be opened within the timeout, an exception will be thrown).

				Your job is to represent these commonalities in a base class called BWConnection.This class should have two properties:
				ConnectionString: string
			   Timeout : TimeSpan
			  A BWConnection will not be in a valid state if it does not have a connection string. 
			  So you need to pass a connection string in the constructor of this class. Also, take into account the scenarios where null or 
			  an empty string is sent as the connection string. Make sure to throw an exception to guarantee that your class will always be in a valid state. 				
			Our BWConnection should also have two methods for opening and closing a connection.
We don’t know how to open or close a connection in a BWConnection and this should be left to the classes that derived from BWConnection. 
These classes (eg SqlConnection or OracleConnection) will provide the actual implementation. So you need to declare these methods as abstract. 
Derive two classes MSSqlConnection and OracleDBConnection from BWConnection and provide a 				
simple implementation of opening and closing connections using Console.WriteLine().
			 */

namespace Project_DatabaseConnection
{
	class Program
	{
		public static object MySql { get; private set; }

		static void Main(string[] args)

		{
			//int a = 1, b = 2;
			//char choice;

			Console.WriteLine("Enter Your Choice 1 for Sql AND 2 For Oracle");
			var type = Console.ReadLine();
			if (Convert.ToInt32(type) == 1)
				Execute1();
			else
				Execute2();
		}
		static void Execute1()
		{
			string Original = "12345";
			Console.WriteLine("Enter Connection string");
			string Connectionstr = Console.ReadLine();

			Sql MySql = new Sql();
			if (string.Compare(Original, Connectionstr) == 0)
				MySql.open();

			if (string.Compare(Original, Connectionstr) != 0)
				MySql.ConnectionClose();
		}
		static void Execute2()
		{
			string Original = "12345";
			Console.WriteLine("Enter Connection string");
			string Connectionstr = Console.ReadLine();
			Oracle Myoracle = new Oracle();
			if (string.Compare(Original, Connectionstr) == 0)

				Myoracle.open();
			if (string.Compare(Original, Connectionstr) != 0)
				Myoracle.ConnectionClose();
		}
	}
	abstract class BWConnection
	{
		public abstract void open();
		public abstract void ConnectionClose();
	}
	class Sql : BWConnection
	{
		public override void open()
		{
			Console.WriteLine("Sql Connection Establish Successful!!!!!11");
			Console.ReadLine();
		}
		public override void ConnectionClose()
		{
			//if (_text != "This is key")
			Console.WriteLine(" String not matching so SQL  Connection Close");
			Console.ReadLine();
		}
	}

	class Oracle : BWConnection
	{
		public override void open()
		{
			Console.WriteLine("Oracle Connection Establish Successful!!!!!11");
			Console.ReadLine();
		}
		public override void ConnectionClose()
		{
			Console.WriteLine(" String not matching so Oracle Connection Close ");
			Console.ReadLine();
		}
	}


}