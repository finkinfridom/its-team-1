<?php
//include "config.php";
//$_POST['guest'];
$sql = "SELECT DATE_FORMAT(ora, '%H:%i')
        FROM orari
        WHERE id_orari NOT IN ( SELECT id_orari
                                FROM prenotazione
                                WHERE giorno LIKE ".$conn->real_escape_string($_POST['datepicker'])."
                                GROUP BY id_orari)";
$result = $conn->query($sql);

/*if ($result->num_rows > 0)
    while ($row = $result->fetch_assoc())
    {
      echo "<option value='".$row['id_orari']."'>".substr($row['ora'], 0, -3)."</option>";
    }*/
$result->close();
//$conn->close();
?>