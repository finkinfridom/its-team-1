<?php
//include "config.php";
$_POST['guest'];
$_POST['datapicker'];

$sql="	SELECT orari.ora
	  	FROM orari
	  	WHERE orari.ora NOT IN(	SELECT orari.ora
					   			FROM orari, prenotazione
					   			WHERE orari.ora BETWEEN prenotazione.ora AND addtime(prenotazione.ora, '01:29:00')
					   			AND prenotazione.giorno='".$conn->real_escape_string($_POST['datepicker'])."')";
$result = $conn->query($sql);

if ($result->num_rows > 0)
    while ($row=$result->fetch_assoc())
    {
    	$return[]=$row;
    }
json_encode($return);
$result->close();
//$conn->close();
?>