import React from 'react'
import OneService from './OneTypeOfService'

function Usluge() {
    return (
        <section className="page-section bg-light" id="portfolio">
            <div className="container">
                <div className="text-center">
                    <h2 className="section-heading text-uppercase">Portfolio</h2>
                    <h3 className="section-subheading text-muted">Lorem ipsum dolor sit amet consectetur.</h3>
                </div>
                <div className="row">
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

export default Usluge
