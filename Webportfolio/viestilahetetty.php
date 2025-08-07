<?php
session_start();
$error = false;
$errormessage = "";


if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    //kentät
    $nimi = $_POST["nimi"];
    $sahkoposti = $_POST["email"];
    $viesti = $_POST["viesti"];

    //jos kentät ei ole tyhjiä, asettaa sessioniin
    if (!empty($nimi) && !empty($sahkoposti) && !empty($viesti)) {
        $_SESSION['nimi'] = $nimi;
        $_SESSION['email'] = $sahkoposti;
        $_SESSION['viesti'] = $viesti;
        $_SESSION['confirmation_viewed'] = false;
        //Lähettää lomakkeen tiedot takaisin tällä sivulle, eli muuttuu periaatteessa "GET" muotoon.
        header("Location: " . $_SERVER['PHP_SELF']);
        exit;
    }
}

if ($_SERVER['REQUEST_METHOD'] === 'GET') {
    //jos ollaan yritetty päästä suoraan viestilahetetty.php sivulle. ilmoittaa virheellisen pääsyn.
    if (!isset($_SESSION['nimi']) || !isset($_SESSION['email']) || !isset($_SESSION['viesti'])) {
        $error = true;
        $errormessage = "Virheellinen pääsy! Käytä yhteystietolomaketta viestin lähettämiseen.";
        //esimerkki työ joten ilmoittaa error messagesta 
        //yleensä voitaisiin suoraan vaan redirectaa:

        //header("Location: clear_session.php");
        //exit;
    }
    //jos sivu on lähetetty ja ladataan uudelleen
    elseif (isset($_SESSION['confirmation_viewed']) && $_SESSION['confirmation_viewed'] === true) {
        header("Location: clear_session.php");
        exit;
    } else {
        //ottaa datan sessionista jos kaikki OK
        $nimi = $_SESSION['nimi'];
        $sahkoposti = $_SESSION['email'];
        $viesti = $_SESSION['viesti'];
        $_SESSION['confirmation_viewed'] = true;
        file_put_contents('data.txt', "$nimi \n $sahkoposti \n $viesti \n\n", FILE_APPEND);
    }
}
?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style.css">
    <title>Viesti lähetetty</title>
</head>

<body>
    <div class="container-fluid-yhteystiedot">
        <div class="col">
            <div class="neon-info-card">
                <div class="yhteystiedot-container">
                    <?php if ($error): // error messaget ?>
                        <h2 class="info-heading" style="color: red;"><?php echo "ERROR: $errormessage"; ?></h2>
                        <div class="neon-content-single" style="margin: 0px !important;">
                            <p style="text-align: center; padding: 20px;">
                                <a href="clear_session.php" class="sendBtn">Palaa yhteystietoihin</a>
                            </p>
                        </div>
                    <?php else: ?>
                        <h2 class="info-heading">Kiitos viestistä!</h2>
                        <div class="neon-content-single" style="margin: 0px !important;">
                            <div class="message-sent" style="display: flex; gap: 9rem; justify-content: center;">
                                <ul style="list-style: none; padding: 20px; text-align: center;">
                                    <h3 style="text-align: center;">Tiedot:</h3>
                                    <li>
                                        <h5>Nimi:</h5>
                                        <p style="word-wrap: break-word; word-break: break-word; white-space: normal;">
                                            <?php echo htmlspecialchars($nimi); ?></p>
                                    </li>
                                    <li>
                                        <h5>Sähköposti:</h5>
                                        <p style="word-wrap: break-word; word-break: break-word; white-space: normal;">
                                            <?php echo htmlspecialchars($sahkoposti); ?></p>
                                    </li>
                                    <li>
                                        <h5>Viesti:</h5>
                                        <p style="word-wrap: break-word; word-break: break-word; white-space: normal;">
                                            <?php echo htmlspecialchars($viesti); ?></p>
                                    </li>
                                </ul>
                            </div>
                            <p style="text-align: center; padding: 20px;">
                                <a href="clear_session.php" class="sendBtn">Palaa yhteystietoihin</a>
                            </p>
                        </div>
                    <?php endif; ?>
                </div>
            </div>
        </div>
    </div>
</body>

</html>
<?php
// poistaa error messaget
if (isset($_SESSION['error'])) {
    unset($_SESSION['error']);
    unset($_SESSION['errormessage']);
}
?>