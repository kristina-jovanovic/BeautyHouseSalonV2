import React from 'react'
import Worker from './Worker'

function Team() {
    return (
        <section className="page-section bg-light" id="team">
            <div className="container">
                <div className="text-center">
                    <h2 className="section-heading text-uppercase">Naš tim</h2>
                    <h3 className="section-subheading text-muted">Upoznajte ljude koji čine da zablistate spolja i iznutra.</h3>
                </div>
                <div id="carouselExampleSlidesOnly" className="carousel slide" data-bs-ride="carousel">
                    <div className="carousel-inner">
                        <div className="carousel-item active">
                            <div className="row">
                                <Worker />
                                <Worker />
                                <Worker />

                            </div>
                        </div>
                        <div className="carousel-item">
                            <div className="row">
                                <Worker />
                                <Worker />
                                <Worker />

                            </div>
                        </div>
                        <div className="carousel-item">
                            <div className="row">
                                <Worker />
                                <Worker />
                                <Worker />

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    )
}

export default Team
