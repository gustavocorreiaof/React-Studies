import React from "react";

export default (props) => {

    const randomNumber = Math.floor(Math.random() * (props.y - props.x + 1)) + props.x;

    return(

        <>
        <h2>O numero aleatorio gerado foi:  {randomNumber}</h2>
        </>
    )

}