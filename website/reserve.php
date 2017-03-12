<?php
	require __DIR__ . '/vendor/autoload.php';
	include "config.php";

	if(isset($_POST['phone']))
	{	
		echo "<p>Riassunto richiesta</p>";
		echo "<p>Nominativo: ".$_POST['first_name']." ".$_POST['last_name']
			."<br/>Tel: ".$_POST['phone']
			."<br/>Numero persone: ".$_POST['guest']
			."<br/>Email conferma: ".$_POST['email']
			."<br/>Prenotazione: ".date("l, d F o", $_POST['datepicker'])." Hr. ".substr($_POST['hour'], 0, -3)."</p>";
		echo "<form action='#' method='post' name='reserve' id='reserve'>";
		$sql="INSERT INTO prenotazione
			  VALUES(id_cliente='".$_POST['cliente']."', giorno='".$_POST['datepicker']."', ora='".$_POST['hour']."', persone='".$_POST['guest']."')";
		$conn->real_query($sql);
		$last_id = $conn->insert_id;
		echo "<input type='hidden' name='id' id='id' value='".$last_id."'>
			<br/><br/><button type='submit' id='submit' name='submit' class='text-center form-btn form-btn'>Prenota il tuo men&ugrave;</button>
			  <button id='termina' name='termina' class='text-center form-btn form-btn' onclick=window.location.href='index.php'>Termina e conferma</button>
			</form>";
	}
	else if(isset($_POST['id']))
	{
		echo "<form action='#' method='post' name='reserve' id='reserve'>
			  </form>";
	}
?>