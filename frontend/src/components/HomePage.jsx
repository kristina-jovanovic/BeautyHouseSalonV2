import React from 'react'
import Home from './Home'
import Services from './Services'
import AboutPage from './AboutPage'
import Team from './Team'
import TypesOfService from './TypesOfService'
import Companies from './Companies'

function HomePage() {
    return (
        <div>
            <Home />
            <TypesOfService />
            <Services />
            <AboutPage />
            <Team />
            <Companies />
        </div>
    )
}

export default HomePage
