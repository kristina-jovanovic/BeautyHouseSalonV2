import axios from 'axios';
import { format, formatISO } from 'date-fns';
import React, { useEffect, useState } from 'react'
import { Button, Modal } from 'react-bootstrap';
import { useNavigate } from 'react-router-dom';

function ReservationPage({ token, user }) {

    const [loading, setLoading] = useState(true);
    const [message, setMessage] = useState('');
    const [title, setTitle] = useState("Greška");
    let navigate = useNavigate();

    useEffect(() => {
        if (token == null) {
            setMessage("Da biste napravili rezervaciju, prvo morate da se ulogujete.");
            handleShow();
        }
    })

    //ucitavanje tipova usluga sa servera tj. iz baze
    const [typesOfService, setTypesOfService] = useState();
    useEffect(() => {
        if (typesOfService == null) {
            let config = {
                method: 'get',
                maxBodyLength: Infinity,
                url: 'api/TipoviUsluga'
            };

            axios.request(config)
                .then((response) => {
                    // console.log(JSON.stringify(response.data));
                    setTypesOfService(response.data);
                    setLoading(false);
                })
                .catch((error) => {
                    console.log(error);
                });

        }

    }, [typesOfService]);

    //ucitavanje usluga sa servera tj. iz baze
    const [services, setServices] = useState();
    function loadServices(tip) {

        let config = {
            method: 'get',
            maxBodyLength: Infinity,
            url: `api/Usluge?filterQuery=${tip}`
        };
        console.log(config.url);
        axios.request(config)
            .then((response) => {
                // console.log(JSON.stringify(response.data));
                setServices(response.data);
                setLoading(false);
            })
            .catch((error) => {
                console.log(error);
            });

    }

    //ucitavanje radnika sa servera tj. iz baze
    const [workers, setWorkers] = useState();
    function loadWorkers(tip) {

        let config = {
            method: 'get',
            maxBodyLength: Infinity,
            url: `api/Radnici?filterQuery=${tip}`
        };
        console.log(config.url);

        axios.request(config)
            .then((response) => {
                // console.log(JSON.stringify(response.data));
                setWorkers(response.data);
                setLoading(false);
            })
            .catch((error) => {
                console.log(error);
            });

    }

    const [reservationData, setReservationData] = useState({
        tipUsluge: '',
        usluga: '',
        radnik: '',
        korisnik: user?.korisnikID,
        datumIVremeTermina: '',
        napomena: ''
    });
    // console.log(reservationData);
    function handleInput(e) {
        let { name, value } = e.target;
        // Ako je polje 'usluga' ili 'radnik', konvertuj u broj
        if (name === 'usluga' || name === 'radnik') {
            value = parseInt(value, 10); // Konvertuj vrednost u broj
        }
        setReservationData((prevData) => {
            const updatedData = {
                ...prevData,
                [name]: value
            };
            console.log('Updated reservationData:', updatedData);
            return updatedData;
        });
    }
    useEffect(() => {
        // kada se tip usluge promeni, ucitaj usluge i radnike za taj tip usluge
        if (reservationData.tipUsluge) {
            loadServices(reservationData.tipUsluge);
            loadWorkers(reservationData.tipUsluge);
        }

    }, [reservationData.tipUsluge]);

    useEffect(() => {
        // kada se usluga automatski menja, poziva se handleInput
        if (reservationData.usluga) {
            handleInput({ target: { name: 'usluga', value: reservationData.usluga } });
        }
    }, [reservationData.usluga]);

    useEffect(() => {
        // kada se radnik automatski menja, poziva se handleInput
        if (reservationData.radnik) {
            handleInput({ target: { name: 'radnik', value: reservationData.radnik } });
        }
    }, [reservationData.radnik]);

    useEffect(() => {
        //kada se promeni lista usluga tj. ucitaju se nove iz baze
        if (services && services.length > 0) {
            setReservationData(prevData => ({
                ...prevData,
                usluga: services[0].uslugaID // postavlja prvu uslugu kao podrazumevanu
            }));
        }
    }, [services]);

    useEffect(() => {
        //kada se promeni lista radnika tj. ucitaju se novi iz baze
        if (workers && workers.length > 0) {
            setReservationData(prevData => ({
                ...prevData,
                radnik: workers[0].radnikID // postavlja prvog radnika kao podrazumevanog
            }));
        }
    }, [workers]);

    //za popunjavanje dropdown liste sa datumIVremeTerminaima
    const [timeSlots, setTimeSlots] = useState([]);
    useEffect(() => {
        const generateTimeSlots = () => {
            const firstHour = 9;
            const lastHour = 17;

            let start = new Date(); //danas
            if (start.getHours() >= lastHour) {
                //ako je danasnje radno vreme proslo, postavi vreme za sutra i prvi datumIVremeTermina u 9h
                start.setHours(firstHour, 0, 0, 0);
                start.setDate(start.getDate() + 1); // Pomeri za sledeći dan
            } else {
                //ako i dalje traje radno vreme danas, dodaj prvi datumIVremeTermina za prvi naredni pun sat
                start.setHours(start.getHours() + 1, 0, 0, 0); // Postavi na sledeći puni sat
            }

            const end = new Date(start);
            end.setMonth(end.getMonth() + 1); // poslednji dan je mesec dana od danasnjeg datuma

            const slots = [];

            while (start < end) {
                //za svaki dan do kraja
                if (start.getHours() >= firstHour && start.getHours() < lastHour) {
                    //ako je start.getHours() u okviru radnog vremena,
                    slots.push(new Date(start)); // Dodaj datumIVremeTermina u listu
                    start.setHours(start.getHours() + 1); // Pomeri za jedan sat na dalje
                } else {
                    // radno vreme za danas je proslo, pomeri na sutrasnji datum i na prvi radni sat
                    start.setHours(firstHour, 0, 0, 0); // Resetuj na prvi sat sledećeg dana
                    start.setDate(start.getDate() + 1); // Pomeri datum
                }
            }
            setTimeSlots(slots);
        };
        generateTimeSlots();
    }, []);

    useEffect(() => {
        // kada se datumIVremeTermina automatski menja, poziva se handleInput
        if (reservationData.datumIVremeTermina) {
            handleInput({ target: { name: 'datumIVremeTermina', value: reservationData.datumIVremeTermina } });
        }
    }, [reservationData.datumIVremeTermina]);

    useEffect(() => {
        //kada se promeni lista datumIVremeTerminaa tj. ucita se na pocetku
        if (timeSlots && timeSlots.length > 0) {
            setReservationData(prevData => ({
                ...prevData,
                datumIVremeTermina: timeSlots[0] // postavlja prvi datumIVremeTermina kao podrazumevan
            }));
        }
    }, [timeSlots]);

    function rezervisi(e) {
        e.preventDefault();

        if (reservationData.tipUsluge === '' || reservationData.usluga === '' || reservationData.radnik === '' || reservationData.datumIVremeTermina === '') {
            setMessage("Sva polja osim napomene su obavezna.");
            handleShow();
        }
        else {
            const termin = Date.parse(reservationData.datumIVremeTermina);
            console.log(termin);
            const formatiranTermin = format(termin, "yyyy-MM-dd'T'HH:mm");
            // const formatiranTermin = formatISO(termin, { representation: 'complete' });
            console.log(formatiranTermin);
            reservationData.datumIVremeTermina = formatiranTermin;

            const datum = new Date();
            console.log(datum);
            const formatiranDatum = format(datum, "yyyy-MM-dd'T'HH:mm:ss");
            // const formatiranDatum = formatISO(datum, { representation: 'complete' });
            console.log(formatiranDatum);


            const data = {
                usluga: { "uslugaID": reservationData.usluga },
                korisnik: { "korisnikID": user?.korisnikID },
                napomena: reservationData.napomena,
                datumIVremeTermina: formatiranTermin,
                radnik: { "radnikID": reservationData.radnik },
                vremeKreiranja: formatiranDatum,
                statusZahteva: 0
            };
            console.log(JSON.stringify(data));
            let config = {
                method: 'post',
                maxBodyLength: Infinity,
                url: 'api/Termini/proveri-raspolozivost',
                data: data,
                headers: {
                    'Content-Type': 'application/json', // Osigurava da server prepozna da saljem JSON
                    //     'Authorization': 'Bearer ' + token
                }
            };

            axios.request(config)
                .then((response) => {
                    console.log(JSON.stringify(response.data));
                    if (response.data === true) {
                        //termin kod izabranog radnika je za sada slobodan

                        const dataList = [data];
                        console.log(JSON.stringify(dataList));


                        let newConfig = {
                            method: 'post',
                            maxBodyLength: Infinity,
                            url: 'api/Termini',
                            data: dataList,
                            headers: {
                                'Content-Type': 'application/json', // Osigurava da server prepozna da saljem JSON
                                //     'Authorization': 'Bearer ' + token
                            }
                        };
                        axios.request(newConfig)
                            .then((response) => {
                                console.log(JSON.stringify(response.data));
                                if (response.data.success === true) {
                                    setMessage("Zahtev za rezervaciju je uspešno poslat! Kada se rezervacija potvrdi ili odbije, stići će ti poruka na email adresu koju si navela prilikom kreiranja naloga.");
                                    setTitle("Potvrda");
                                    handleShow();
                                }
                                else {
                                    setMessage("Došlo je do greške.")
                                    handleShow();
                                }

                            })
                            .catch((error) => {
                                setMessage(error);
                                handleShow();
                            });


                    }
                    else {
                        setMessage("Izabrani radnik je već zauzet u izabranom terminu. Izmenite željeni termin ili radnika.");
                        handleShow();
                    }
                })
                .catch((error) => {
                    setMessage(error);
                    handleShow();
                });

            // navigate('/');
        }

    }

    const [show, setShow] = useState(false);

    const handleClose = () => setShow(false);
    const handleShow = () => setShow(true);

    return (
        <section className="h-100 gradient-form bg-dark"
            style={{ padding: "5rem 0" }}
        >
            <div className="container py-5 h-100" >
                <div className="row d-flex justify-content-center align-items-center h-100">
                    <div className="col-xl-10">
                        <div className="card rounded-3 text-black bg-light">
                            <div className="row g-0">
                                <div className="col-12 col-lg-8">
                                    <div className="card-body p-md-5 mx-md-4">

                                        <div className="text-center">
                                            <h4 className="mt-1 mb-5 pb-1"
                                            // style={{color:"#ff6eb7"}}
                                            >BEAUTY HOUSE</h4>
                                        </div>

                                        <form>
                                            <div data-mdb-input-init className="form-outline mb-4">
                                                <label htmlFor="sel1">Tip usluge</label>
                                                <select className="form-select" id="sel1" onChange={handleInput} name='tipUsluge'
                                                    value={reservationData.tipUsluge}
                                                >
                                                    <option value="" disabled hidden>Izaberi tip usluge</option>
                                                    {typesOfService?.map((type) => (
                                                        <option key={type.tipUslugeID} value={type.nazivTipaUsluge}>{type.nazivTipaUsluge}</option>
                                                    ))}
                                                </select>
                                            </div>
                                            <div data-mdb-input-init className="form-outline mb-4">
                                                <label htmlFor="sel2">Usluga</label>
                                                <select className="form-select" id="sel2" onChange={handleInput} name='usluga'
                                                    value={reservationData.usluga} >
                                                    {services?.map((service) => (
                                                        <option key={service.uslugaID} value={service.uslugaID}>{service.naziv}</option>
                                                    ))}
                                                </select>
                                            </div>
                                            <div data-mdb-input-init className="form-outline mb-4">
                                                <label htmlFor="sel3">Radnik</label>
                                                <select className="form-select" id="sel3" onChange={handleInput} name='radnik'
                                                    value={reservationData.radnik}>
                                                    {workers?.map((worker) => (
                                                        <option key={worker.radnikID} value={worker.radnikID}>{worker.ime} {worker.prezime}</option>
                                                    ))}
                                                </select>
                                            </div>
                                            <div data-mdb-input-init className="form-outline mb-4">
                                                <label htmlFor="sel4">Termin</label>
                                                <select className="form-select" id="sel4" onChange={handleInput} name='datumIVremeTermina'>
                                                    {timeSlots.map((slot, index) => (
                                                        <option key={index} value={slot.toISOString()}>
                                                            {slot.toLocaleString('sr-RS', { day: '2-digit', month: '2-digit', year: 'numeric', hour: '2-digit', minute: '2-digit' })}
                                                        </option>
                                                    ))}
                                                </select>
                                            </div>
                                            <div data-mdb-input-init className="form-outline mb-4">
                                                <label htmlFor="text1">Napomena</label>
                                                <input type="text" id="text1" className="form-control"
                                                    placeholder='Unesi napomenu (opciono)' onInput={(e) => handleInput(e)} name="napomena" />
                                            </div>


                                            <div className="text-center pt-1 mb-5 pb-1">
                                                <button type="submit" data-mdb-button-init data-mdb-ripple-init className="btn btn-primary btn-block fa-lg mb-3"
                                                    style={{ display: "block", width: "100%" }} onClick={rezervisi}>REZERVIŠI TERMIN</button>
                                            </div>

                                        </form>
                                    </div>
                                </div>
                                <div className="col-12 col-lg-4 d-flex align-items-center round-edges" style={{
                                    // backgroundColor: "#ff6eb7" 
                                    // backgroundImage: `url(${photo})`,
                                    backgroundImage: 'url(https://i.shgcdn.com/96050615-b80f-4062-8a1f-643472712403/-/format/auto/-/preview/3000x3000/-/quality/lighter/)',
                                    backgroundSize: 'cover', // Osigurava da se slika skalira
                                    backgroundPosition: 'center', // Centriranje slike
                                    minHeight: '300px'
                                }}>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <Modal show={show} onHide={handleClose} >
                <Modal.Header closeButton>
                    <Modal.Title>{title}</Modal.Title>
                </Modal.Header>
                <Modal.Body>{message}</Modal.Body>
                <Modal.Footer>
                    <Button variant="primary" onClick={() => {
                        handleClose();
                        if(title==="Potvrda"){
                            navigate('/');
                        }
                        setTitle("Greška");
                        if (token == null) {
                            navigate('/login');
                        }
                    }}>
                        OK
                    </Button>
                </Modal.Footer>
            </Modal>
        </section>
    )
}

export default ReservationPage
