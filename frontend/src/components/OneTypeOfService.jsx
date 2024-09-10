import React from 'react'

function OneTypeOfService({ type, iconClass }) {
    let icon = "fas fa-stack-1x fa-inverse fa-solid " + iconClass;


    return (
        <div className="col-md-20 scale-transition">
            <span className="fa-stack fa-4x">
                {/* krug kao pozadina za ikonicu */}
                <i className="fas fa-circle fa-stack-2x text-primary"></i>
                {/* ikonica */}
                <i className={icon}></i>
            </span>
            <h4 className="my-3">{type.nazivTipaUsluge}</h4>
        </div>
    )
}

export default OneTypeOfService
