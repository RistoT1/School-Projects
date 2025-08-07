<?php include "../partials/nav.php";?>
<style>
        .liikuntatyypit {
            display: flex;
            flex-wrap: wrap;
            gap: 20px;
            justify-content: space-between;
        }
        .liikuntatyyppi {
            flex: 1;
            min-width: 300px;
            background-color:rgb(232, 241, 245);
            padding: 20px;
            border-radius: 5px;
            box-shadow: 0 2px 5px rgba(0,0,0,0.1);
        }
        .lajit {
            display: grid;
            grid-template-columns: repeat(auto-fill, minmax(250px, 1fr));
            gap: 15px;
            margin-top: 30px;
        }
        .laji {
            background-color:rgb(232, 241, 245);
            padding: 15px;
            border-radius: 5px;
            box-shadow: 0 2px 5px rgba(0,0,0,0.1);
        }
        ul {
            padding-left: 20px;
        }
        li {
            margin-bottom: 8px;
        }
        main{
            margin-top: 50px;
            margin-bottom: 50px;
        }
        a {
            text-decoration: none;
        }
    </style>
<main>
    <section class="liikuntatyypit">
        <div class="liikuntatyyppi">
            <h2>Aloittelijalle</h2>
            <p>Aloittelijalle sopivia liikuntamuotoja ovat matalan kynnyksen lajit, joissa loukkaantumisriski on pieni ja tekniikan opettelu helppoa.</p>
            <ul>
                <li>Kävely ja sauvakävely</li>
                <li>Uinti ja vesijumppa</li>
                <li>Pyöräily tasaisessa maastossa</li>
                <li>Jooga (aloittelijoiden tunnit)</li>
                <li>Kuntosaliharjoittelu ohjatusti</li>
                <li>Tanssilliset ryhmäliikuntatunnit</li>
            </ul>
            <p><strong>Vinkki:</strong> Aloita rauhallisesti 2-3 kertaa viikossa ja lisää liikuntaa vähitellen. Kuuntele kehoasi ja anna sen palautua harjoitusten välillä.</p>
        </div>

        <div class="liikuntatyyppi">
            <h2>Kuntoliikkujalle</h2>
            <p>Kuntoliikkujalle sopivia lajeja ovat monipuoliset liikuntamuodot, jotka kehittävät kestävyyttä, voimaa ja liikkuvuutta.</p>
            <ul>
                <li>Juoksu ja polkujuoksu</li>
                <li>Crossfit ja toiminnallinen harjoittelu</li>
                <li>Hiit-treenit (High-Intensity Interval Training)</li>
                <li>Pyöräily, spinning</li>
                <li>Kuntosaliharjoittelu</li>
                <li>Pallopelit (tennis, sulkapallo, padel)</li>
                <li>Voimajooga ja pilates</li>
            </ul>
            <p><strong>Vinkki:</strong> Yhdistele erilaisia liikuntamuotoja saadaksesi monipuolisia treenivaikutuksia. Huolehdi myös riittävästä palautumisesta.</p>
        </div>

        <div class="liikuntatyyppi">
            <h2>Urheilijalle</h2>
            <p>Kokeneille urheilijoille sopivia harjoitusmuotoja ovat intensiiviset ja tavoitteelliset harjoitukset, jotka kehittävät suorituskykyä monipuolisesti.</p>
            <ul>
                <li>Intervalli- ja nopeusharjoittelu</li>
                <li>Periodisoidut voimaharjoittelun ohjelmat</li>
                <li>Lajikohtainen tekniikka- ja taitoharjoittelu</li>
                <li>Kilpailuun valmistavat harjoitukset</li>
                <li>Korkean intensiteetin kestävyysharjoittelu</li>
                <li>Liikkuvuus- ja kehonhuoltoharjoitukset</li>
            </ul>
            <p><strong>Vinkki:</strong> Huolehdi kokonaisvaltaisesta harjoittelusta, johon kuuluu myös aktiivinen palautuminen, riittävä uni ja terveellinen ravinto.</p>
        </div>
    </section>

    <section>
        <h2>Erilaisia liikuntalajeja</h2>
        <p>Tutustu alla oleviin liikuntalajeihin ja löydä itsellesi sopiva harrastus:</p>

        <div class="lajit">
            <div class="laji">
                <h3>Kestävyyslajit</h3>
                <ul>
                    <li><a href="https://www.juoksija.fi/" target="_blank">Juoksu</a></li>
                    <li><a href="https://pyoraily.fi/" target="_blank">Pyöräily</a></li>
                    <li><a href="https://www.uimaliitto.fi/" target="_blank">Uinti</a></li>
                    <li><a href="https://www.hiihtoliitto.fi/" target="_blank">Hiihto</a></li>
                    <li><a href="https://www.triathlonliitto.fi/" target="_blank">Triathlon</a></li>
                </ul>
            </div>

            <div class="laji">
                <h3>Voimaharjoittelu</h3>
                <ul>
                    <li><a href="https://suomenvoimanostoliitto.fi/" target="_blank">Voimanosto</a></li>
                    <li><a href="https://painonnosto.fi/" target="_blank">Painonnosto</a></li>
                    <li><a href="https://www.kuntosaliharjoittelu.fi/" target="_blank">Kuntosaliharjoittelu</a></li>
                    <li><a href="https://www.crossfit.com/" target="_blank">CrossFit</a></li>
                    <li><a href="https://fitnessurheilu.fi/" target="_blank">Fitness</a></li>
                </ul>
            </div>

            <div class="laji">
                <h3>Kehonhuolto ja mieli</h3>
                <ul>
                    <li><a href="https://www.joogaliitto.fi/" target="_blank">Jooga</a></li>
                    <li><a href="https://www.suomenpilatesyhdistys.fi/" target="_blank">Pilates</a></li>
                    <li><a href="https://www.taiji.fi/" target="_blank">Taiji</a></li>
                    <li><a href="https://www.venyttely.fi/" target="_blank">Venyttely</a></li>
                    <li><a href="https://www.mindfulness.fi/" target="_blank">Mindfulness</a></li>
                </ul>
            </div>

            <div class="laji">
                <h3>Palloilulajit</h3>
                <ul>
                    <li><a href="https://www.palloliitto.fi/" target="_blank">Jalkapallo</a></li>
                    <li><a href="https://www.basket.fi/" target="_blank">Koripallo</a></li>
                    <li><a href="https://www.lentopalloliitto.fi/" target="_blank">Lentopallo</a></li>
                    <li><a href="https://www.salibandyliitto.fi/" target="_blank">Salibandy</a></li>
                    <li><a href="https://www.padel.fi/" target="_blank">Padel</a></li>
                </ul>
            </div>

            <div class="laji">
                <h3>Kamppailulajit</h3>
                <ul>
                    <li><a href="https://www.judoliitto.fi/" target="_blank">Judo</a></li>
                    <li><a href="https://www.karateliitto.fi/" target="_blank">Karate</a></li>
                    <li><a href="https://www.taekwondo.fi/" target="_blank">Taekwondo</a></li>
                    <li><a href="https://www.painiliitto.fi/" target="_blank">Paini</a></li>
                    <li><a href="https://www.nyrkkeilyliitto.fi/" target="_blank">Nyrkkeily</a></li>
                </ul>
            </div>

            <div class="laji">
                <h3>Tanssi ja rytmiliikunta</h3>
                <ul>
                    <li><a href="https://www.dancesport.fi/" target="_blank">Kilpatanssi</a></li>
                    <li><a href="https://www.tanssi.fi/" target="_blank">Nykytanssi</a></li>
                    <li><a href="https://www.bailatino.fi/" target="_blank">Bailatino</a></li>
                    <li><a href="https://www.zumba.com/" target="_blank">Zumba</a></li>
                    <li><a href="https://www.voimisteluliitto.fi/" target="_blank">Voimistelu</a></li>
                </ul>
            </div>
        </div>
    </section>

    <section>
        <h2>Liikunta eri vuodenaikoina</h2>
        <p>Suomen neljä vuodenaikaa tarjoavat monipuolisia mahdollisuuksia liikunnan harrastamiseen:</p>
        
        <div class="lajit">
            <div class="laji">
                <h3>Kesälajit</h3>
                <ul>
                    <li><a href="https://www.melontajasoutuliitto.fi/" target="_blank">Melonta ja soutu</a></li>
                    <li><a href="https://www.purjehdusjaveneily.fi/" target="_blank">Purjehdus</a></li>
                    <li><a href="https://www.golf.fi/" target="_blank">Golf</a></li>
                    <li><a href="https://www.yleisurheiluliitto.fi/" target="_blank">Yleisurheilu</a></li>
                    <li><a href="https://www.uimarannat.fi/" target="_blank">Avovesiuinti</a></li>
                </ul>
            </div>

            <div class="laji">
                <h3>Talvilajit</h3>
                <ul>
                    <li><a href="https://www.hiihtoliitto.fi/maastohiihto/" target="_blank">Maastohiihto</a></li>
                    <li><a href="https://www.skisport.fi/alppihiihto/" target="_blank">Alppihiihto</a></li>
                    <li><a href="https://www.luisteluliitto.fi/" target="_blank">Luistelu</a></li>
                    <li><a href="https://www.jaakiekkoliitto.fi/" target="_blank">Jääkiekko</a></li>
                    <li><a href="https://www.lumikenkaily.fi/" target="_blank">Lumikenkäily</a></li>
                </ul>
            </div>
        </div>
    </section>
</main>
<?php include "footer.php"; ?>
</body>
</html>