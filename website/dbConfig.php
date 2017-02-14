<?php

/*define ("DB_HOST", "***********"); // set database host
define ("DB_USER", "**********"); // set database user
define ("DB_PASS","**********"); // set database password
define ("DB_NAME","*********"); // set database name*/

define ("DB_HOST", "db4free.net:3307"); // set database host
define ("DB_USER", "itsteam1"); // set database user
define ("DB_PASS","progetto"); // set database password
define ("DB_NAME","ristorante"); // set database name

//create connection
$conn = mysqli_connect(DB_HOST, DB_USER, DB_PASS, DB_NAME);
//check connection
    if ($conn->connect_error) {
        die('Errore di connessione (' . $db->connect_errno . ') '. $conn->connect_error);
    }
?>
