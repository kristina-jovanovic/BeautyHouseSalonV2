import React, { useEffect, useState } from 'react'
import Worker from './Worker'
import axios from 'axios';
import Loader from './Loader';

function Team() {
    const [loading, setLoading] = useState(true);

    const [workerChunks, setWorkerChunks] = useState();

    // Function to split workers into groups of three
    const chunkWorkers = (arr, chunkSize) => {
        let result = [];
        for (let i = 0; i < arr.length; i += chunkSize) {
            result.push(arr.slice(i, i + chunkSize));
        }
        return result;
    };

    const [workers, setWorkers] = useState();
    useEffect(() => {
        if (workers == null) {
            let config = {
                method: 'get',
                maxBodyLength: Infinity,
                url: 'api/Radnici'
            };

            axios.request(config)
                .then((response) => {
                    // console.log(JSON.stringify(response.data));
                    setWorkers(response.data);
                    setLoading(false);
                    // setWorkerChunks(chunkWorkers(workers,3));
                })
                .catch((error) => {
                    console.log(error);
                });
        }
        else {
            setWorkerChunks(chunkWorkers(workers, 3));
        }

    }, [workers]);
    return (
        <section className="page-section bg-light" id="team">
            <div className="container">
                <div className="text-center">
                    <h2 className="section-heading text-uppercase">Naš tim</h2>
                    <h3 className="section-subheading text-muted">Upoznajte ljude koji čine da zablistate spolja i iznutra.</h3>
                </div>
                <div id="carouselExampleSlidesOnly" className="carousel slide" data-bs-ride="carousel">
                    <div className="carousel-inner" style={{ overflow: 'visible' }}>
                        {loading ? (
                            <div className='d-flex justify-content-center align-items-center'>
                                <Loader />
                            </div>
                        ) : (
                            workerChunks?.map((chunk, index) => (
                                <div className={`carousel-item ${index === 0 ? 'active' : ''}`} key={index}>
                                    <div className="row">
                                        {chunk.map((worker) => (
                                            <Worker worker={worker} key={worker.radnikId} />
                                        ))}
                                    </div>
                                </div>
                            ))
                        )}
                    </div>
                </div>
            </div>
        </section>
    )
}

export default Team
