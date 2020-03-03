package pG_DbTest;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.TimerTask;

public class TimerController extends TimerTask{
	Scheduler scheduler=new Scheduler();
	@Override
	public void run() 
	{
		StartUp program = new StartUp();
		try {
			
			program.main(null);
			DateFormat df = new SimpleDateFormat("dd/MM/yy HH:mm:ss");
		       Date dateobj = new Date();
		       System.out.println(df.format(dateobj));
		} catch (InterruptedException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

}