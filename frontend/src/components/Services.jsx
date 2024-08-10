import React from 'react'
import OneService from './OneService'

function Services() {
    return (
        <section className="page-section bg-light" id="portfolio">
            <div className="container">
                <div className="text-center">
                    <h2 className="section-heading text-uppercase">Usluge</h2>
                    <h3 className="section-subheading text-muted">Izaberi i zakaži tretman za sebe.</h3>
                </div>
                <div className="row">
                    <OneService />
                    <OneService />
                    <OneService />
                    <OneService />
                    <OneService />
                    <OneService />

                </div>
            </div>
        </section>
    )
}

export default Services
