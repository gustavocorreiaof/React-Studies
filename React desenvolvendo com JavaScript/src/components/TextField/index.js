import './TextField.css'

const TextField = (props) => {
    return(
        <div className='textfield'>
            <label>{props.Label}</label>
            <input placeholder={props.PlaceHolder}/>
        </div>
    )
}

export default TextField;