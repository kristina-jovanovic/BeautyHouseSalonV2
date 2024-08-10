import React, { useEffect, useState } from 'react'
import OneTypeOfService from './OneTypeOfService'
import axios from 'axios';

function TypesOfServices() {

    // const [typesOfService, setTypesOfService] = useState();
    // useEffect(() => {
    //     if (typesOfService == null) {
    //         let config = {
    //             method: 'get',
    //             maxBodyLength: Infinity,
    //             url: 'api/TipoviUsluga',
    //             headers: {
    //                 'Access-Control-Allow-Origin': '*',
    //             }
    //         };

    //         axios.request(config)
    //             .then((response) => {
    //                 console.log(JSON.stringify(response));
    //                 console.log(JSON.stringify(response.data));
    //                 setTypesOfService(response.data);
    //             })
    //             .catch((error) => {
    //                 console.log(error);
    //             });

    //     }

    //     // Access to XMLHttpRequest at 'http://localhost:5170/api/TipoviUsluga' from origin 'http://localhost:3000' 
    //     // has been blocked by CORS policy: Response to preflight request doesn't pass access control check: Redirect is not allowed for a preflight request.
    // }, [typesOfService]);


    return (
        <div>
            <section className="page-section" id="services">
                <div className="container">
                    <div className="text-center">
                        <h2 className="section-heading text-uppercase">Tipovi usluga</h2>
                        <h3 className="section-subheading text-muted">Pogledaj šta te sve očekuje u našem salonu.</h3>
                    </div>
                    <div className="row text-center">
                        <OneTypeOfService />
                        <OneTypeOfService />
                        <OneTypeOfService />
                        <OneTypeOfService />
                        <OneTypeOfService />
                    </div>
                </div>
            </section>
        </div>
    )
}

export default TypesOfServices
