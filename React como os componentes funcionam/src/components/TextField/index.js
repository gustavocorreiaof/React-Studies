import { useState } from 'react'
import './TextField.css'

const TextField = (props) => {
    
    const [valor, setValor] = useState('')

    const valorDigitado = (event) => {
        props.aoAlterado(event.target.value)
    }
    
    return(
        <div className='textfield'>
            <label>{props.Label}</label>
            <input value={props.valor} onChange={valorDigitado} required={props.required} placeholder={props.PlaceHolder}/>
        </div>
    )
}

export default TextField;