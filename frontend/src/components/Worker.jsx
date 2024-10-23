import React from 'react'

function Worker({ worker }) {
    return (
        <div className="col-lg-4 scale-transition">
            <div className="team-member"
                style={{ height: "100%" }}

            >
                <img src={worker.fotografija} className="mx-auto rounded-circle" alt="worker" />
                <h4>{worker.ime} {worker.prezime}</h4>
                <p className="text-muted">{worker.tipUsluge.nazivTipaUsluge}</p>
                <p>{worker.opis}</p>
            </div>
        </div>
    )
}

export default Worker
