import React from 'react'
import logo from '../resources/BeautyHouseLogo.png'

function Worker() {
    return (
        <div className="col-lg-4">
            <div className="team-member"
                style={{ height: "100%", alignContent: "center" }}

            >
                <img className="mx-auto rounded-circle" src={logo} alt="worker" />
                <h4>Parveen Anand</h4>
                <p className="text-muted">Lead Designer</p>
                <p>Lorem ipsum, dolor sit amet consectetur adipisicing elit. Facere saepe illo accusantium perferendis? Ipsum dignissimos, facere amet provident vel dolor ex omnis, ullam sint, ad eligendi neque error officiis sed.</p>
            </div>
        </div>
    )
}

export default Worker
