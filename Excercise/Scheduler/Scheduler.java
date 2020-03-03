package pG_DbTest;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.time.Duration;
import java.time.LocalDateTime;
import java.time.ZoneId;
import java.time.ZonedDateTime;
import java.util.Date;
import java.util.Timer;


public class Scheduler
{	
	static Timer time = new Timer();
	public static void main(String[] args) 
	{   		
		DateFormat df = new SimpleDateFormat("dd/MM/yy HH:mm:ss");
	       Date dateobj = new Date();
	       System.out.println(df.format(dateobj));
		long val=computeNextDelay(8, 5, 00);
		new Scheduler().scheduleTask(val*1000);
	}

	public void scheduleTask(long val)
	{
		TimerController timeController = new TimerController();
		time.schedule(timeController, val);
	}
	
	public static long computeNextDelay(int targetHour, int targetMin, int targetSec) 
    {
        LocalDateTime localNow = LocalDateTime.now();
        ZoneId currentZone = ZoneId.systemDefault();
        ZonedDateTime zonedNow = ZonedDateTime.of(localNow, currentZone);
        ZonedDateTime zonedNextTarget = zonedNow.withHour(targetHour).withMinute(targetMin).withSecond(targetSec);
        if(zonedNow.compareTo(zonedNextTarget)>0)
        {
        	zonedNextTarget = zonedNextTarget.plusDays(1);
        }

        Duration duration = Duration.between(zonedNow, zonedNextTarget);
        return duration.getSeconds();
    }
	
}