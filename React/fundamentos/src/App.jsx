import React from "react";

import First from './Components/Basics/FirstComponent'
import ComParametro from './Components/Basics/ComParametro'
import Fragmento from './Components/Basics/Fragmento'
import Aleatorio from "./Components/Basics/Aleatorio";
import Card from "./Components/Basics/Layout/Card";

export default props => {
    return (

        <div id="app">
            <Card titulo="Exercicio Numero Aleatorio">
                <Aleatorio x={0} y={100}></Aleatorio>
            </Card>

            <Card titulo="Primeiro Componente">
                <First></First>
            </Card>

            <Card titulo="Fragmento">
                <Fragmento></Fragmento>
            </Card>

            <Card titulo="Com parametro">
                <ComParametro titulo="Componenteaa com Parametro" subtitulo="Primeiro Componente com parametro"></ComParametro>
            </Card>

        </div>

    )
}