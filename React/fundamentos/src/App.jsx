import React from "react";

import First from './Components/Basics/FirstComponent'
import ComParametro from './Components/Basics/ComParametro'
import Fragmento from './Components/Basics/Fragmento'
import Aleatorio from "./Components/Basics/Aleatorio";

export default props => {
    return (

        <div id="app">

            <Aleatorio x={0} y={100}></Aleatorio>

            <Fragmento></Fragmento>

            <First></First>
            <ComParametro titulo="Componenteaa com Parametro" subtitulo="Primeiro Componente com parametro"></ComParametro>

        </div>

    )
}