import React, { Component } from 'react'
import File from './FileUploadComponents/File'
import FileButton from './FileUploadComponents/FileButton'

export class FileUpload extends Component{
    constructor(props){
        super(props);
        this.state = {
            file: null,
            fileName : ""
          }
    }
    readFileDataAsBase64 = e => {
        const file = e.target.files[0];
    
        return new Promise((resolve, reject) => {
            const reader = new FileReader();
    
            reader.onload = (event) => {
                resolve(event.target.result);
            };
    
            reader.onerror = (err) => {
                reject(err);
            };
    
            reader.readAsDataURL(file);
        });
    }
  onChange = e => {
    this.readFileDataAsBase64(e)
        .then(res=>{
          this.setState({ file:res, fileName:e.target.files[0].name })
          this.props.setFile({file:res});
        })
  }

  removeFile = () => {
    this.setState({
      file: null,
      fileName:""
    })
    this.props.setFile({file:null});
  }
  
  render() {
    const { uploading, file,fileName } = this.state
    const content = () => {
      switch(true) {
        case file !== null:
          return <File file={fileName} removeFile={this.removeFile} />
        default:
          return <FileButton accept={this.props.accept} onChange={this.onChange} />
      }
    }

    return (
      <div>
        <div className='buttons'>
          {content()}
        </div>
      </div>
    )
  }
}