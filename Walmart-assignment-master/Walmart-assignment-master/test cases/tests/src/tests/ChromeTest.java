package tests;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;


public class ChromeTest {
	public static void main(String[] args) throws InterruptedException {
	System.setProperty("webdriver.chrome.driver", "chromedriver.exe");
	WebDriver driver = new ChromeDriver();
	//driver.get("http://google.com");
	driver.get("file:///C:/website/Index.html#/");
	Thread.sleep(5000);
	driver.findElement(By.xpath("//input[@type='text']")).sendKeys("ipod");
	driver.findElement(By.xpath("//button[@type='submit']")).click();
	driver.findElement(By.xpath("//img[@class='panel-body']")).click();
	driver.quit();
	
	}
}
