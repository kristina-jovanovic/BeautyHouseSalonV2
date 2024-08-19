import React from 'react'
import Home from './Home'
import Services from './Services'
import AboutPage from './AboutPage'
import Team from './Team'
import TypesOfService from './TypesOfService'
import Companies from './Companies'

function HomePage({addService}) {
    return (
        <div>
            <Home />
            <TypesOfService />
            <Services addService={addService} />
            <AboutPage />
            <Team />
            <Companies />
        </div>
    )
}

export default HomePage
