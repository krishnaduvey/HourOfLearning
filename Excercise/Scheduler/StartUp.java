package pG_DbTest;

import java.sql.Connection;

public class StartUp {

	public static void main(String[] args) throws InterruptedException {

		String from="/Users/deviceconnect/ReusableLibrary/workspace1/PG_DbTest/src/configFiles/";
		String to="/usr/local/var/postgres";
		
		String[] host = {"10.4.5.135"};
		String dbUser = "deviceconnect";
		String dbPassword = "GoMobile!";		
		String[] files= {"pg_hba.conf","postgresql.conf"};		
		System.out.println("Db Configuration Updation start ");
		PostgresConfigChange.ProstgresConfig(host,dbUser,dbPassword,from,to,files);
		Thread.sleep(3000*60);
		DbConnection.DbConnection(host);
		System.out.println("Db Configuration Updation end ");
		
	}

}
