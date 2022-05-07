<!DOCTYPE html>

<html>
     <head>
	 <meta charset = "utf-8">
	 <title>Order Summary</Title>
	 <style type = "text/css">
		p {margin:0px;}
		.error {color:red}
		p.head {font-weight: bold; margin-top: 10px;}
	 </style>
     </head>
     <body>
	  <?php
	     if(!preg_match( "/^\([0-9]{3}\) [0-9]{3}-[0-9]{4}$/",
		$_POST["phone"]))
	     {
		print("<p class = 'error'>Invalid phone number.</p>
		<p>A valid phone number must be in the form (555) 555-5555</p>
		<p>Click the back button, enter a valid phone number and resubmit.</p>
		<p>Thank You.</p></body></html>");
		die();
	     }
	   ?>

<?php

$charge =0;
 
if($_POST['sections']=='Orchestra')
{
    $charge = 65;
}
else if($_POST['sections']=='Mezzanine')
{
    $charge = 40;
}
else if($_POST['sections']=='General')
{
     $charge = 35;
}
else if($_POST['sections']=='Balcony')
{
     $charge = 20;
}


print("<p> charge $charge</p>");


?>
	 
		
</body>
</html>