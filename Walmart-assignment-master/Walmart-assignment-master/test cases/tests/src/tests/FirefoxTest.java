package tests;

import java.util.List;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.firefox.FirefoxDriver;
public class FirefoxTest {

	
	public static void main(String[] args) throws InterruptedException {
	System.setProperty("webdriver.gecko.driver", "geckodriver.exe");
	WebDriver driver = new FirefoxDriver();
	
	//driver.get("http://google.com");
	driver.get("file:///C:/website/Index.html#/");
	driver.findElement(By.xpath("//input[@type='text']")).sendKeys("ipod");
	driver.findElement(By.xpath("//button[@type='submit']")).click();
	Thread.sleep(2000);
	List<WebElement> list = driver.findElements(By.xpath("//*[@class='panel-heading']"));
	Thread.sleep(2000);
	System.out.println(list.size());
	list.get(3).click();
	driver.quit();
	}
	
}

/*
options = webdriver.ChromeOptions()
options.add_argument('--ignore-certificate-errors')
options.add_argument("--test-type")
options.binary_location = "/usr/bin/chromium"
driver = webdriver.Chrome(chrome_options=options)
driver.get('https://secure.indeed.com/account/login?hl=en_US&co=US&continue=https%3A%2F%2Fwww.indeed.com%2F&tmpl=desktop&service=my&from=gnav-util-homepage&jsContinue=https%3A%2F%2Fwww.indeed.com%2F&empContinue=https%3A%2F%2Faccount.indeed.com%2Fmyaccess&_ga=2.40831462.590242016.1634485813-1059659394.1634485813')

text_area = driver.find_element_by_id('login-email-input')
text_area.send_keys("christian-bauer@hotmail.com")

text_area = driver.find_element_by_id('login-password-input')
text_area.send_keys("ad$QNJY$oy")
*/