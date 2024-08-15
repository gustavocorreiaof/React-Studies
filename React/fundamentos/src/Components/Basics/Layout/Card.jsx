import React from "react";
import "./Card.css"

export default props => {
    return (
        <>

            <div className="Card">
                <div className="Titulo">{props.titulo}</div>
                <div className="Content">
                    {props.children}

                </div>
            </div>

        </>
    )
}