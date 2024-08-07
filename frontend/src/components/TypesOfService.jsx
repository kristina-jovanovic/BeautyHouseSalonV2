import React from 'react'
import OneTypeOfService from './OneTypeOfService'

function Services() {
    return (
        <div>
            <section className="page-section" id="services">
                <div className="container">
                    <div className="text-center">
                        <h2 className="section-heading text-uppercase">Services</h2>
                        <h3 className="section-subheading text-muted">Lorem ipsum dolor sit amet consectetur.</h3>
                    </div>
                    <div className="row text-center">
                        <OneTypeOfService />
                        <OneTypeOfService />
                        <OneTypeOfService />
                    </div>
                </div>
            </section>
        </div>
    )
}

export default Services
