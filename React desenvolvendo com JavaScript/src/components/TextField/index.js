import './TextField.css'

const TextField = (props) => {
    
    const valorDigitado = (event) => {
        console.log(event.target.value)
    }
    
    return(
        <div className='textfield'>
            <label>{props.Label}</label>
            <input onChange={valorDigitado} required={props.required} placeholder={props.PlaceHolder}/>
        </div>
    )
}

export default TextField;