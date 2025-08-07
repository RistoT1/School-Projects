<?php
session_start();
?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>yhteystiedot</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet"
        integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css" />
    <link rel="stylesheet" href="style.css">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"
        integrity="sha384-YvpcrYf0tYB3tP6KOa3F5ZuhyEPyehfiJ8aZjg5rZ9E+Kj+PB8p5h9bt" crossorigin="anonymous"></script>
</head>

<body>
    <?php include "nav.php" ?>
    <main>
        <div class="container-fluid-yhteystiedot">
            <div class="col">
                <div class="neon-info-card">
                    <div class="glow"></div>
                    <div class="glow"></div>
                    <div class="neon-border"></div>

                    <div class="message-container">
                        <div class="messahe-header">
                            <h1>Lähetä viesti</h1>
                        </div>
                        <form class="contact-form" id="contactForm" action="viestilahetetty.php" method="post">
                            <div class="input-group">
                                <label for="name">nimi:</label>
                                <input type="text" id="nimi" name="nimi" maxlength="100" placeholder="Syötä nimesi"
                                    required>
                            </div>

                            <div class="input-group">
                                <label for="email">Sähköposti:</label>
                                <input type="email" id="email" name="email" maxlength="320"
                                    placeholder="Syötä sähköposti osoite" required>
                            </div>

                            <div class="input-group">
                                <label for="message">Viesti:</label>
                                <textarea id="viesti" name="viesti" maxlength="800" placeholder="Viesti tähän..."
                                    required></textarea>
                            </div>

                            <input class="sendBtn" type="submit" id="sendBtn"></input>
                        </form>
                    </div>
                    <div class="yhteystiedot-container">
                        <h2 class="info-heading">yhteystiedot</h2>
                        <div class="neon-content-single" style="margin: 0px !important;">
                            <div style="display: flex; gap: 9rem; justify-content: center;">
                                <ul style="list-style: none; padding: 20px;">
                                    <li>
                                        <h5>Nimi</h5>
                                        <p>Risto Toivanen</p>
                                    </li>
                                    <li>
                                        <h5>Sähköposti</h5>
                                        <p>ristotoiv.rt@gmail.com</p>
                                    </li>
                                    <li>
                                        <h5>Puhelinnumero</h5>
                                        <p>0449787010</p>
                                    </li>
                                </ul>
                                <ul style="list-style: none; padding: 20px;">
                                    <li>
                                        <h5>Osoite</h5>
                                        <p>Huuhankatu xxx</p>
                                    </li>
                                    <li>
                                        <h5>Postitoimipaikka</h5>
                                        <p>70600</p>
                                    </li>
                                    <li>
                                        <h5>Kunta</h5>
                                        <p>Kuopio</p>
                                    </li>
                                </ul>
                            </div>
                        </div>
                        <div class="iframe-container"
                            style="margin-top: 30px; width: 100%; border-radius: 10px; overflow: hidden; box-shadow: 0 4px 8px rgba(0,0,0,0.1);">
                            <iframe
                                src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d463761.7986338933!2d27.01459402481265!3d62.99629439675565!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4684b08aaffec4f3%3A0xe7b6f77d9edff6c0!2sKuopio!5e0!3m2!1sfi!2sfi!4v1745573956731!5m2!1sfi!2sfi"
                                width="100%" height="450" style="border: 0; display: block;" allowfullscreen=""
                                loading="lazy" referrerpolicy="no-referrer-when-downgrade">
                            </iframe>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </main>
</body>

</html>