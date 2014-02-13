﻿
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1318
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoShow.Streaming.Services.Config
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class JobFile
    {
        private Job[] jobField;
        private string versionField;

        [System.Xml.Serialization.XmlElementAttribute("Job", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Job[] Job
        {
            get { return this.jobField; }
            set { this.jobField = value; }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version
        {
            get { return this.versionField; }
            set { this.versionField = value; }
        }
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Job
    {
        private MediaFile[] mediaFilesField;
        private string outputDirectoryField;
        private string saveJobFileField;
        private string appendJobIDField;

        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("MediaFile", typeof(MediaFile), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public MediaFile[] MediaFiles
        {
            get { return this.mediaFilesField; }
            set { this.mediaFilesField = value; }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OutputDirectory
        {
            get { return this.outputDirectoryField; }
            set { this.outputDirectoryField = value; }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SaveJobFile
        {
            get { return this.saveJobFileField; }
            set { this.saveJobFileField = value; }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AppendJobID
        {
            get { return this.appendJobIDField; }
            set { this.appendJobIDField = value; }
        }
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MediaFile
    {
        private Marker[] markersField;
        private string sourceField = null;
        private string videoSizeField = null;
        private string videoProfileField = null;
        private string audioProfileField = null;
        private string thumbnailModeField = null;
        private string thumbnailSizeField = null;
        private string startTimeField = null;
        private string endTimeField = null;
        private string markerThumbnailSizeField = null;
        private string overlayFileField = null;
        private string overlayRectField = null;
        private string overlayOpacityField = null;

        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Marker", typeof(Marker), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public Marker[] Markers
        {
            get { return this.markersField; }
            set { this.markersField = value; }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Source
        {
            get { return this.sourceField; }
            set { this.sourceField = value; }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VideoSize
        {
            get { return this.videoSizeField; }
            set { this.videoSizeField = value; }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ThumbnailMode
        {
            get { return this.thumbnailModeField; }
            set { this.thumbnailModeField = value; }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ThumbnailSize
        {
            get { return this.thumbnailSizeField; }
            set { this.thumbnailSizeField = value; }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StartTime
        {
            get { return this.startTimeField; }
            set { this.startTimeField = value; }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EndTime
        {
            get { return this.endTimeField; }
            set { this.endTimeField = value; }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VideoProfile
        {
            get { return this.videoProfileField; }
            set { this.videoProfileField = value; }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AudioProfile
        {
            get { return this.audioProfileField; }
            set { this.audioProfileField = value; }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MarkerThumbnailSize
        {
            get { return this.markerThumbnailSizeField; }
            set { this.markerThumbnailSizeField = value; }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OverlayFile
        {
            get { return this.overlayFileField; }
            set { this.overlayFileField = value; }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OverlayRect
        {
            get { return this.overlayRectField; }
            set { this.overlayRectField = value; }
        }

        public void SetOverlayRect(int left, int top, int width, int height)
        {
            OverlayRect = String.Format("{0}, {1}, {2}, {3}", left, top, width, height);
        }

        /// <summary>
        /// Opacitiy, between 0 and 1.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OverlayOpacityField
        {
            get { return this.overlayOpacityField; }
            set { this.overlayOpacityField = value; }
        }
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Marker
    {
        private string timeField;
        private string valueField;
        private string generateKeyFrameField;
        private string generateThumbnailField;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Time
        {
            get { return this.timeField; }
            set { this.timeField = value; }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GenerateKeyFrame
        {
            get { return this.generateKeyFrameField; }
            set { this.generateKeyFrameField = value; }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GenerateThumbnail
        {
            get { return this.generateThumbnailField; }
            set { this.generateThumbnailField = value; }
        }
    }
}