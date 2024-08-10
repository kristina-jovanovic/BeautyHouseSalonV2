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
                <div id="carouselExampleSlidesOnly" class="carousel slide" data-bs-ride="carousel">
                    <div class="carousel-inner">
                        <div class="carousel-item active">
                            <div className="row">
                                <Worker />
                                <Worker />
                                <Worker />

                            </div>
                        </div>
                        <div class="carousel-item">
                            <div className="row">
                                <Worker />
                                <Worker />
                                <Worker />

                            </div>
                        </div>
                        <div class="carousel-item">
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
