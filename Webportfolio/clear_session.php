<?php
session_start();
// unsettaa arvot
unset($_SESSION['nimi']);
unset($_SESSION['email']);
unset($_SESSION['viesti']);
unset($_SESSION['confirmation_viewed']);


header("Location: yhteystiedot.php");
exit;
?>
