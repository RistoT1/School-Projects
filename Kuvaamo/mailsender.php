<?php
use PHPMailer\PHPMailer\PHPMailer;
use PHPMailer\PHPMailer\Exception;
use PHPMailer\PHPMailer\SMTP;

session_start();

// Generate CSRF token if it doesn't exist
if (empty($_SESSION['csrf_token'])) {
    $_SESSION['csrf_token'] = bin2hex(random_bytes(32));
}

$nimi = $_POST['nimi'] ?? '';
$sahkoposti = $_POST['sahkoposti'] ?? '';
$viesti = $_POST['viesti'] ?? '';

// Initialize variables
$emailSent = false;
$emailError = '';

// Only try to send email if the form was submitted with all required fields
if ($_SERVER['REQUEST_METHOD'] === 'POST' && 
    !empty($nimi) && 
    !empty($sahkoposti) && 
    !empty($viesti) &&
    isset($_POST['csrf_token']) && 
    $_POST['csrf_token'] === $_SESSION['csrf_token']) {
    
    // Validate email format
    if (!filter_var($sahkoposti, FILTER_VALIDATE_EMAIL)) {
        $emailError = "Sähköpostiosoite ei ole kelvollinen.";
    } else {
        // Load credentials from separate config file
        // Using the correct path to Config folder (with capital C)
        $config = require 'Config/mail_config.php';
        
        // Use PHPMailer - Updated paths to match your structure
        require 'mailer/src/PHPMailer.php';
        require 'mailer/src/SMTP.php';
        require 'mailer/src/Exception.php';
        
        // Create a new PHPMailer instance
        $mail = new PHPMailer(true);
        
        try {
            // Server settings
            $mail->isSMTP();
            $mail->Host       = $config['host'];
            $mail->SMTPAuth   = true;
            $mail->Username   = $config['username'];
            $mail->Password   = $config['password'];
            $mail->SMTPSecure = PHPMailer::ENCRYPTION_STARTTLS;
            $mail->Port       = $config['port'];
            
            // Recipients
            // Set the sender as your own email (not the user's)
            $mail->setFrom($config['from_email'], $config['from_name']);
            // Add reply-to with the user's email
            $mail->addReplyTo($sahkoposti, $nimi);
            // Set the destination address
            $mail->addAddress($config['to_email']);
            
            // Content
            $mail->isHTML(false);
            $mail->Subject = "Yhteydenotto verkkosivulta";
            $mail->Body    = "Nimi: " . $nimi . "\n";
            $mail->Body   .= "Sähköposti: " . $sahkoposti . "\n";
            $mail->Body   .= "Viesti: " . $viesti . "\n";
            
            $mail->send();
            $emailSent = true;
            
            // Generate new CSRF token after successful submission
            $_SESSION['csrf_token'] = bin2hex(random_bytes(32));
        } catch (Exception $e) {
            $emailError = "Viestiä ei voitu lähettää. Yritä myöhemmin uudelleen.";
            // Log actual error for administrator (not visible to users)
            error_log("PHPMailer Error: {$mail->ErrorInfo}");
        }
    }
}
?>

<!DOCTYPE html>
<html lang="fi">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Kiitos yhteydenotosta</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
    <link rel="stylesheet" href="yhteistiedot.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <style>
        .thank-you-container {
            text-align: center;
            max-width: 600px;
            margin: 0 auto;
            padding: 50px 20px;
            background-color: white;
            border-radius: 8px;
            box-shadow: 0 2px 10px rgba(214, 53, 140, 0.1);
            margin-top: 50px;
        }
        
        .thank-you-title {
            color: #d6358c;
            font-size: 36px;
            margin-bottom: 20px;
            font-weight: bold;
        }
        .syotetyt-tiedot-title{
            color: #d6358c;
            font-size: 28px;
            margin-bottom: 20px;
            font-weight: bold;
        }
        .syotetyt-tiedot p{
            word-wrap: break-word;
            overflow-wrap: break-word;
            white-space: normal;
        }
        
        .thank-you-message {
            color: #333;
            font-size: 18px;
            margin-bottom: 30px;
            line-height: 1.6;
        }
        
        .back-button {
            background-color: #ff66b3;
            color: white;
            border: none;
            padding: 12px 30px;
            border-radius: 4px;
            cursor: pointer;
            font-size: 16px;
            transition: background-color 0.3s;
            text-decoration: none;
            display: inline-block;
        }
        
        .back-button:hover {
            background-color: #d6358c;
            color: white;
            text-decoration: none;
        }
        
        .error-message {
            color: #d9534f;
            background-color: #f2dede;
            border: 1px solid #ebccd1;
            padding: 15px;
            margin-bottom: 20px;
            border-radius: 4px;
            text-align: center;
        }
    </style>
</head>
<body>
    <nav class="navbar navbar-default custom-navbar navbar-fixed-top">
        <div class="container-fluid">
            <div class="navbar-header">
                <a class="navbar-brand" href="#">Crazy kuvat</a>
                <button type="button" class="navbar-toggle collapsed" data-toggle="collapse"
                    data-target="#navbarNavAltMarkup" aria-expanded="false">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
            </div>
            <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
                <ul class="nav navbar-nav">
                    <li><a href="index.html" class="smooth-scroll">Etusivu</a></li>
                    <li><a href="#" class="smooth-scroll">Hinnasto</a></li>
                    <li class="active"><a href="yhteistiedot.php">Yhteistiedot</a></li>
                </ul>
            </div>
        </div>
    </nav>
    
    <main style="padding-top: 70px;">
        <div class="container">
            <?php if (!empty($emailError)): ?>
                <div class="thank-you-container">
                    <div class="error-message"><?php echo htmlspecialchars($emailError); ?></div>
                    <a href="yhteistiedot.php" class="back-button">Takaisin lomakkeeseen</a>
                </div>
            <?php elseif ($emailSent): ?>
                <div class="thank-you-container">
                    <h1 class="thank-you-title">KIITOS</h1>
                    <p class="thank-you-message">Kiitos yhteydenotosta! </p>
                    <p class="thank-you-message">Olemme sinuun yhteydessä mahdollisimman pian.</p>
                    <div class="syotetyt-tiedot">
                        <h2 class="syotetyt-tiedot-title">Syötetyt tiedot</h2>
                        <p>Nimi: <?php echo htmlspecialchars($nimi); ?></p>
                        <p>Sähköposti: <?php echo htmlspecialchars($sahkoposti); ?></p>
                        <p>Viesti: <?php echo htmlspecialchars($viesti); ?></p>
                    </div>
                    <a href="index.html" class="back-button">Takaisin etusivulle</a>
                </div>
            <?php else: ?>
                <div class="thank-you-container">
                    <h1 class="thank-you-title">Lomaketta ei lähetetty</h1>
                    <p class="thank-you-message">Palaa takaisin lomakkeeseen ja yritä uudelleen.</p>
                    <a href="yhteistiedot.php" class="back-button">Takaisin lomakkeeseen</a>
                </div>
            <?php endif; ?>
        </div>
    </main>
</body>
</html>