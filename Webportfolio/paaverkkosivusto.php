<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>webportfolio</title>
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
        <div class="fixed-arrow-scroller">
            <div class="arrow-btn up-arrow" data-direction="up">
                <i class="fa-solid fa-arrow-up"></i>
            </div>
            <div class="arrow-btn down-arrow" data-direction="down">
                <i class="fa-solid fa-arrow-down"></i>
            </div>
        </div>

        <div class="container-fluid">
            <div class="row rivi1" id="rivi1">
                <div class="col nimi-container">
                    <h2>Risto Toivanen</h2>
                    <p>Hei! Olen Risto, opiskelen Savon ammattiopistossa tieto ja viestintä tekniikkaa. Pidän
                        ohjelmoinnista
                        ja tykkään tehdä pieniä projekteja eri kielillä. Harrastan myös Jalkapalloa ja käyn aktiivisesti
                        kuntosalilla.</p>
                    <button class="yhteystiedot-nappi"><span><a href="yhteystiedot.php">yhteystiedot</a></span></button>
                </div>
                <div class="col kuva-container">
                    <div class="img-container">
                        <img src="src/Risto_toivanen_igkuva.jpg" alt="Risto Toivanen">
                    </div>
                </div>
                <div class="neon-border"></div>
            </div>
            

            <div class="row content-row rivi2" id="rivi2">
                <div class="col">
                    <div class="neon-info-card">
                        <div class="glow"></div>
                        <div class="glow"></div>
                        <div class="neon-border"></div>
                        <h2 class="info-heading">Koulutus</h2>
                        <div class="neon-content-single">
                            <div class="neon-column-single">
                                <div class="lista">
                                    <ul class="koulutus-list">
                                        <li>
                                            <h5>Peruskoulu</h5>
                                            <p class="nimike">Juantehtaan koulu</p>
                                        </li>
                                        <li>
                                            <h5>Ammattikoulutus</h5>
                                            <p class="nimike">Ohjelmistokehitys</p>
                                            <p style="font-size: 16px;">Ensimmäisen vuoden ohjelmistokehittäjä.</p>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col">
                    <div class="neon-info-card">
                        <div class="glow"></div>
                        <div class="glow"></div>
                        <div class="neon-border"></div>
                        <h2 class="text-center mb-4">Työkokemus</h2>
                        <div class="neon-content-single">
                            <div class="neon-column-single">
                                <h3>S-market Nilsiä</h3>
                                <div class="lista">
                                    <ul>
                                        <li>
                                            <h5>S-market Nilsiä 2024</h5>
                                            <p class="nimike">Myyjä</p>
                                            <p>Työjakson pituus: 3kk</p>
                                            <p>6-8.2024</p>
                                        </li>
                                        <li>
                                            <h5>S-market Nilsiä 2023</h5>
                                            <p class="nimike">Myyjä</p>
                                            <p>Työjakson pituus: 2vk</p>
                                            <p>20.6-4.7.2023</p>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row content-row rivi3" id="rivi3">
                <div class="neon-info-card">
                    <div class="glow"></div>
                    <div class="glow"></div>
                    <div class="neon-border"></div>
                    <h2 class="text-center mb-4">Kiinnostuksen kohteet</h2>
                    <div class="neon-content">
                        <div class="neon-column">
                            <h3>Urheilu</h3>
                            <p>Harrastan jalkapalloa Kuopion palloseurassa ja käyn aktiivisesti kuntosalilla.
                            </p>
                        </div>
                        <div class="neon-column">
                            <h3>Ohjelmointi</h3>
                            <p>Pidän ohjelmoinnista ja tykkään tehdä pieniä projekteja eri ohjelmointikielillä.
                            </p>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row content-row rivi4" id="rivi4" style="min-height: 70vh;">
                <div class="row content-row" id="taidot">
                    <div class="col-12 ohjelmointitaidot">
                        <div class="neon-info-card">
                            <div class="glow"></div>
                            <div class="glow"></div>
                            <div class="neon-border"></div>
                            <div class="col-12 ohjelmointitaidot-title">
                                <h2 class="text-center">Ohjelmointi taidot <i class="fa-solid fa-code"></i></h2>
                            </div>
                            <div class="skill html">
                                <div class="skill-name">
                                    <p>HTML <i class="fa-brands fa-html5"></i></p>
                                </div>
                                <div class="bar">
                                    <div class="bar-fill"><span class="label"></span></div>
                                </div>
                            </div>

                            <div class="skill css">
                                <div class="skill-name">
                                    <p>CSS</p>
                                </div>
                                <div class="bar">
                                    <div class="bar-fill"><span class="label"></span></div>
                                </div>
                            </div>

                            <div class="skill javascript">
                                <div class="skill-name">
                                    <p>JavaScript <i class="fa-brands fa-square-js"></i></p>
                                </div>
                                <div class="bar">
                                    <div class="bar-fill"><span class="label"></span></div>
                                </div>
                            </div>

                            <div class="skill bootstrap">
                                <div class="skill-name">
                                    <p>BootStrap <i class="fa-brands fa-bootstrap"></i></p>
                                </div>
                                <div class="bar">
                                    <div class="bar-fill"><span class="label"></span></div>
                                </div>
                            </div>

                            <div class="skill C-sharp">
                                <div class="skill-name">
                                    <p>C#</p>
                                </div>
                                <div class="bar">
                                    <div class="bar-fill"><span class="label"></span></div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col">
                        <div class="neon-info-card">
                            <div class="glow"></div>
                            <div class="neon-border"></div>
                            <h2 class="text-center">Projektini</h2>
                            <div class="neon-content-column">
                                <div class="row justify-content-center">
                                    <div class="col text-center">
                                        <p>3.2025</p>
                                        <p>Oma persoonallinen webportfolio</p>
                                        <div class="project-img-container">
                                            <img src="src/Risto_toivanen_igkuva.jpg" alt="">
                                        </div>
                                        <div class="inspect-container">
                                            <a class="github" target="_blank"
                                                href="https://github.com/RistoT1/Web-portfolio">github <i
                                                    class="fa-brands fa-github"></i></a>
                                            <a class="live" target="_blank"
                                                href="https://webportfolio-risto.netlify.app/">demo
                                                <i class="fa-solid fa-bolt"></i></a>
                                        </div>
                                    </div>
                                    <div class="col text-center">
                                        <p>3.2025</p>
                                        <p>Selain sivut</p>
                                        <div class="project-img-container">
                                            <img src="src/google.png" alt="">
                                        </div>
                                        <div class="inspect-container">
                                            <a class="github" target="_blank"
                                                href="https://github.com/RistoT1/Google-home-page">github <i
                                                    class="fa-brands fa-github"></i></a>
                                            <a class="live" target="_blank" href="https://google-rt.netlify.app/">demo
                                                <i class="fa-solid fa-bolt"></i></a>
                                        </div>
                                    </div>
                                    <div class="col text-center">
                                        <p>3.2025</p>
                                        <p>Henkilö tunnuksen tarkistus</p>
                                        <div class="project-img-container">
                                            <img style="height: 150px;" src="src/henkilotunnus.png" alt="">
                                        </div>
                                        <div class="inspect-container">
                                            <a class="github" target="_blank"
                                                href="https://github.com/RistoT1/Henkil-tunnuksen_tarkistus">github <i
                                                    class="fa-brands fa-github"></i></a>
                                        </div>
                                    </div>
                                    <div class="col text-center">
                                        <p>3.2025</p>
                                        <p>Muita koulu projekteja</p>
                                        <div class="project-img-container">
                                            <img src="src/school.png" alt="">
                                        </div>
                                        <div class="inspect-container">
                                            <a class="github" target="_blank"
                                                href="https://github.com/RistoT1/School-Projects">github <i
                                                    class="fa-brands fa-github"></i></a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row content-row rivi5" id="rivi5" style="min-height: 70vh;">
                <div class="col-12">
                    <div class="neon-info-card">
                        <div class="glow"></div>
                        <div class="neon-border"></div>
                        <h2 class="text-center mb-4"><i class="fa-solid fa-circle-question"></i> Millaisia töitä
                            haen
                        </h2>
                        <p>
                            Olen kiinnostunut ohjelmistokehityksestä, jossa pääsen rakentamaan kestäviä,
                            käytettäviä ja
                            kekseliäitä ratkaisuja – oli kyse sitten web-sovelluksista, mobiilikehityksestä tai
                            taustajärjestelmien rakentamisesta.
                        </p>
                        <p>Haen erityisesti projekteja, joissa:</p>
                        <ul>
                            <li>Teknologia kohtaa luovuuden</li>
                            <li>Käyttäjäkokemus on keskiössä</li>
                            <li>Pääsen oppimaan ja kehittymään tiimissä tai itsenäisesti</li>
                        </ul>
                        <p>Kehitän jatkuvasti taitojani.</p>
                    </div>
                </div>
                <div class="col-12">
                    <div class="neon-info-card text-center">
                        <div class="glow"></div>
                        <div class="neon-border"></div>
                        <h2>Kiinnostuitko?</h2>
                        <p>Jos sinulla on projekti mielessä tai haluat vain vaihtaa ajatuksia teknologiasta –
                            ota
                            rohkeasti yhteyttä!📫</p>
                        <button class="yhteystiedot-nappi"><span><a href="yhteystiedot.php">Ota yhteyttä</a></span></button>
                    </div>
                </div>
            </div>
        </div>
    </main>
    <?php include "footer.php"?>
    <script>
        document.addEventListener('DOMContentLoaded', function () {
            const sections = ['rivi1', 'rivi2', 'rivi3', 'rivi4', 'rivi5', 'rivi6'];
            let currentSectionIndex = 0;

            function getCurrentSectionIndex() {
                const scrollPosition = window.pageYOffset + (window.innerHeight / 3);
                let closestSection = 0;
                let closestDistance = Infinity;

                // Find the section closest to the current scroll position
                for (let i = 0; i < sections.length; i++) {
                    const section = document.getElementById(sections[i]);
                    if (!section) continue;

                    const sectionTop = section.offsetTop;
                    const sectionMiddle = sectionTop + (section.offsetHeight / 2);
                    const distance = Math.abs(scrollPosition - sectionMiddle);

                    if (distance < closestDistance) {
                        closestDistance = distance;
                        closestSection = i;
                    }
                }

                return closestSection;
            }

            // Check if we're at the very bottom of the page
            function isAtBottom() {
                const scrollPosition = window.pageYOffset + window.innerHeight;
                const pageHeight = document.documentElement.scrollHeight;
                return Math.abs(scrollPosition - pageHeight) < 20; // 20px tolerance
            }

            // Update current section index on scroll with debounce
            let scrollTimeout;
            window.addEventListener('scroll', function () {
                clearTimeout(scrollTimeout);
                scrollTimeout = setTimeout(function () {
                    currentSectionIndex = getCurrentSectionIndex();

                    // If at bottom of page, force to last section
                    if (isAtBottom()) {
                        currentSectionIndex = sections.length - 1;
                    }

                    updateArrowVisibility();
                }, 100);
            });

            // Initialize with current section
            currentSectionIndex = getCurrentSectionIndex();
            updateArrowVisibility();

            // Function to update arrow visibility
            function updateArrowVisibility() {
                const upArrow = document.querySelector('.up-arrow');
                const downArrow = document.querySelector('.down-arrow');

                // Hide up arrow at first section
                if (currentSectionIndex === 0) {
                    upArrow.style.visibility = 'hidden';
                } else {
                    upArrow.style.visibility = 'visible';
                }

                // Hide down arrow at last section or when at bottom of page
                if (currentSectionIndex === sections.length - 1 || isAtBottom()) {
                    downArrow.style.visibility = 'hidden';
                } else {
                    downArrow.style.visibility = 'visible';
                }

                // Debug info - can be removed in production
                console.log("Current section index:", currentSectionIndex, "Section ID:", sections[currentSectionIndex]);
            }

            // Add event listeners to the arrow buttons
            document.querySelectorAll('.arrow-btn').forEach(btn => {
                btn.addEventListener('click', function () {
                    const direction = this.getAttribute('data-direction');

                    let newIndex = currentSectionIndex;
                    if (direction === 'up' && currentSectionIndex > 0) {
                        newIndex--;
                    } else if (direction === 'down' && currentSectionIndex < sections.length - 1) {
                        newIndex++;
                    }

                    // Only update if the index actually changed
                    if (newIndex !== currentSectionIndex) {
                        currentSectionIndex = newIndex;
                        const targetId = sections[currentSectionIndex];
                        const targetElement = document.getElementById(targetId);

                        if (targetElement) {
                            scrollToSection(targetElement);
                        }
                    }
                });
            });

            // Improved smooth scrolling function
            function scrollToSection(targetElement) {
                const startPosition = window.pageYOffset;
                let targetPosition = targetElement.offsetTop;

                // Apply custom offsets for specific sections
                if (targetElement.id === 'rivi4') {
                    targetPosition -= 130; // Show ohjelmointitaidot title
                } else if (targetElement.id === 'rivi5') {
                    targetPosition -= 200; // Better positioning
                } else if (targetElement.id === 'rivi6') {
                    // For footer, scroll almost to bottom but not quite
                    targetPosition = document.documentElement.scrollHeight - window.innerHeight - 10;
                }

                const distance = targetPosition - startPosition;
                const duration = 800;
                let startTime = null;

                function easeInOutCubic(t) {
                    return t < 0.5 ? 4 * t * t * t : 1 - Math.pow(-2 * t + 2, 3) / 2;
                }

                function animation(currentTime) {
                    if (startTime === null) startTime = currentTime;
                    const timeElapsed = currentTime - startTime;
                    const progress = Math.min(timeElapsed / duration, 1);
                    const easing = easeInOutCubic(progress);

                    window.scrollTo({
                        top: startPosition + distance * easing,
                        behavior: 'auto' // We're handling the animation ourselves
                    });

                    if (timeElapsed < duration) {
                        requestAnimationFrame(animation);
                    } else {
                        // Update state after scrolling completes
                        setTimeout(() => {
                            updateArrowVisibility();
                        }, 50);
                    }
                }

                requestAnimationFrame(animation);
            }

            // Initial update
            updateArrowVisibility();
        });
    </script>
</body>
</html>