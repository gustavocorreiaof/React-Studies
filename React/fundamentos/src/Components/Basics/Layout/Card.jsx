import React from "react";
import "./Card.css"

export default props => {

    const style = {
        backgroundColor: props.color || 'grey'
    }

    return (
        <>

            <div className="Card" style={style}>
                <div className="Titulo">{props.titulo}</div>
                <div className="Content">
                    {props.children}

                </div>
            </div>

        </>
    )
}