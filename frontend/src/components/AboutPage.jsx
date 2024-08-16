import React from 'react'
import photo1 from '../resources/bh-1.jpg'
import photo2 from '../resources/bh-2.jpg'
import photo3 from '../resources/bh-3.jpg'
import photo4 from '../resources/bh-4.jpg'

function AboutPage() {
    return (
        <section className="page-section" id="about">
            <div className="container">
                <div className="text-center">
                    <h2 className="section-heading text-uppercase">Zaviri u naš salon</h2>
                    <h3 className="section-subheading text-muted">Lorem ipsum dolor sit amet consectetur.</h3>
                </div>
                <div id="carouselExampleAutoplaying" className="carousel slide" data-bs-ride="carousel">
                    <div className="carousel-inner" style={{ height: '65vh' }}>
                        <div className="carousel-item active" >
                            <img src={photo1} className="d-block w-100 img-fluid card-img-top image" alt="salon photo" style={{ transform: "translateY(-15%)" }} />
                        </div>
                        <div className="carousel-item">
                            <img src={photo2} className="d-block w-100 img-fluid card-img-top image" alt="salon photo" style={{ transform: "translateY(-15%)" }} />
                        </div>
                        <div className="carousel-item">
                            <img src={photo3} className="d-block w-100 img-fluid card-img-top image" alt="salon photo" style={{ transform: "translateY(-15%)" }} />
                        </div>
                        <div className="carousel-item">
                            <img src={photo4} className="d-block w-100 img-fluid card-img-top image" alt="salon photo" style={{ transform: "translateY(-15%)" }} />
                        </div>
                    </div>
                    <button className="carousel-control-prev" type="button" data-bs-target="#carouselExampleAutoplaying" data-bs-slide="prev">
                        <span className="carousel-control-prev-icon" aria-hidden="true"></span>
                        <span className="visually-hidden">Previous</span>
                    </button>
                    <button className="carousel-control-next" type="button" data-bs-target="#carouselExampleAutoplaying" data-bs-slide="next">
                        <span className="carousel-control-next-icon" aria-hidden="true"></span>
                        <span className="visually-hidden">Next</span>
                    </button>
                </div>
            </div>
        </section>
    )
}

export default AboutPage
