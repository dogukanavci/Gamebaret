
import React from 'react'

export default props => 
  <div className='buttons fadein'>
    <div className='button'>
      <label htmlFor='single'>
      </label>
      <input type='file' accept={props.accept} id='single' onChange={props.onChange} /> 
    </div>
  </div>