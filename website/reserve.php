<?php
//da riempire con i dati inviati dal modulo della pagina reservation.php
include "dbConfig.php";
echo "<p>Riassunto richiesta</p>";
echo "<form>"
	.$_POST['first_name']
	." ".$_POST['last_name']
	."<br/>".$_POST['datepicker']
	."<br/>Tel: ".$_POST['phone']
	."<br/>Numero persone: ".$_POST['guest']
	."<br/>Email conferma: ".$_POST['email']
	."<br/>Prenotazione: ".$_POST['datepicker'];

$sql = "SELECT orari
        FROM orari
        WHERE id_orari=".$_POST['hour'];
$result = $conn->query($sql);
$row = $result->fetch_assoc();

echo " hr. ".$row['orari'];
$result->close();

?>