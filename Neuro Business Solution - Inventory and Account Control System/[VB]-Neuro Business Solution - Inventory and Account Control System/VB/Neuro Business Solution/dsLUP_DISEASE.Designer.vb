﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System


<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"),  _
 Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.ComponentModel.ToolboxItem(true),  _
 System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema"),  _
 System.Xml.Serialization.XmlRootAttribute("dsLUP_DISEASE"),  _
 System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")>  _
Partial Public Class dsLUP_DISEASE
    Inherits System.Data.DataSet
    
    Private tableLUP_DISEASE As LUP_DISEASEDataTable
    
    Private _schemaSerializationMode As System.Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Sub New()
        MyBase.New
        Me.BeginInit
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler MyBase.Relations.CollectionChanged, schemaChangedHandler
        Me.EndInit
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Sub New(ByVal info As System.Runtime.Serialization.SerializationInfo, ByVal context As System.Runtime.Serialization.StreamingContext)
        MyBase.New(info, context, false)
        If (Me.IsBinarySerialized(info, context) = true) Then
            Me.InitVars(false)
            Dim schemaChangedHandler1 As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
            AddHandler Me.Tables.CollectionChanged, schemaChangedHandler1
            AddHandler Me.Relations.CollectionChanged, schemaChangedHandler1
            Return
        End If
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(String)),String)
        If (Me.DetermineSchemaSerializationMode(info, context) = System.Data.SchemaSerializationMode.IncludeSchema) Then
            Dim ds As System.Data.DataSet = New System.Data.DataSet
            ds.ReadXmlSchema(New System.Xml.XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("LUP_DISEASE")) Is Nothing) Then
                MyBase.Tables.Add(New LUP_DISEASEDataTable(ds.Tables("LUP_DISEASE")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.ReadXmlSchema(New System.Xml.XmlTextReader(New System.IO.StringReader(strSchema)))
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property LUP_DISEASE() As LUP_DISEASEDataTable
        Get
            Return Me.tableLUP_DISEASE
        End Get
    End Property
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.ComponentModel.BrowsableAttribute(true),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Visible)>  _
    Public Overrides Property SchemaSerializationMode() As System.Data.SchemaSerializationMode
        Get
            Return Me._schemaSerializationMode
        End Get
        Set
            Me._schemaSerializationMode = value
        End Set
    End Property
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public Shadows ReadOnly Property Tables() As System.Data.DataTableCollection
        Get
            Return MyBase.Tables
        End Get
    End Property
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public Shadows ReadOnly Property Relations() As System.Data.DataRelationCollection
        Get
            Return MyBase.Relations
        End Get
    End Property
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Sub InitializeDerivedDataSet()
        Me.BeginInit
        Me.InitClass
        Me.EndInit
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Overrides Function Clone() As System.Data.DataSet
        Dim cln As dsLUP_DISEASE = CType(MyBase.Clone,dsLUP_DISEASE)
        cln.InitVars
        cln.SchemaSerializationMode = Me.SchemaSerializationMode
        Return cln
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As System.Xml.XmlReader)
        If (Me.DetermineSchemaSerializationMode(reader) = System.Data.SchemaSerializationMode.IncludeSchema) Then
            Me.Reset
            Dim ds As System.Data.DataSet = New System.Data.DataSet
            ds.ReadXml(reader)
            If (Not (ds.Tables("LUP_DISEASE")) Is Nothing) Then
                MyBase.Tables.Add(New LUP_DISEASEDataTable(ds.Tables("LUP_DISEASE")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.ReadXml(reader)
            Me.InitVars
        End If
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New System.Xml.XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New System.Xml.XmlTextReader(stream), Nothing)
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Friend Overloads Sub InitVars()
        Me.InitVars(true)
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Friend Overloads Sub InitVars(ByVal initTable As Boolean)
        Me.tableLUP_DISEASE = CType(MyBase.Tables("LUP_DISEASE"),LUP_DISEASEDataTable)
        If (initTable = true) Then
            If (Not (Me.tableLUP_DISEASE) Is Nothing) Then
                Me.tableLUP_DISEASE.InitVars
            End If
        End If
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Private Sub InitClass()
        Me.DataSetName = "dsLUP_DISEASE"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/dsLUP_DISEASE.xsd"
        Me.EnforceConstraints = true
        Me.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        Me.tableLUP_DISEASE = New LUP_DISEASEDataTable
        MyBase.Tables.Add(Me.tableLUP_DISEASE)
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Private Function ShouldSerializeLUP_DISEASE() As Boolean
        Return false
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Shared Function GetTypedDataSetSchema(ByVal xs As System.Xml.Schema.XmlSchemaSet) As System.Xml.Schema.XmlSchemaComplexType
        Dim ds As dsLUP_DISEASE = New dsLUP_DISEASE
        Dim type As System.Xml.Schema.XmlSchemaComplexType = New System.Xml.Schema.XmlSchemaComplexType
        Dim sequence As System.Xml.Schema.XmlSchemaSequence = New System.Xml.Schema.XmlSchemaSequence
        xs.Add(ds.GetSchemaSerializable)
        Dim any As System.Xml.Schema.XmlSchemaAny = New System.Xml.Schema.XmlSchemaAny
        any.Namespace = ds.Namespace
        sequence.Items.Add(any)
        type.Particle = sequence
        Return type
    End Function
    
    Public Delegate Sub LUP_DISEASERowChangeEventHandler(ByVal sender As Object, ByVal e As LUP_DISEASERowChangeEvent)
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"),  _
     System.Serializable(),  _
     System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>  _
    Partial Public Class LUP_DISEASEDataTable
        Inherits System.Data.DataTable
        Implements System.Collections.IEnumerable
        
        Private columnnCODE As System.Data.DataColumn
        
        Private columnsDESC As System.Data.DataColumn
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub New()
            MyBase.New
            Me.TableName = "LUP_DISEASE"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Friend Sub New(ByVal table As System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Sub New(ByVal info As System.Runtime.Serialization.SerializationInfo, ByVal context As System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property nCODEColumn() As System.Data.DataColumn
            Get
                Return Me.columnnCODE
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property sDESCColumn() As System.Data.DataColumn
            Get
                Return Me.columnsDESC
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Default ReadOnly Property Item(ByVal index As Integer) As LUP_DISEASERow
            Get
                Return CType(Me.Rows(index),LUP_DISEASERow)
            End Get
        End Property
        
        Public Event LUP_DISEASERowChanging As LUP_DISEASERowChangeEventHandler
        
        Public Event LUP_DISEASERowChanged As LUP_DISEASERowChangeEventHandler
        
        Public Event LUP_DISEASERowDeleting As LUP_DISEASERowChangeEventHandler
        
        Public Event LUP_DISEASERowDeleted As LUP_DISEASERowChangeEventHandler
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overloads Sub AddLUP_DISEASERow(ByVal row As LUP_DISEASERow)
            Me.Rows.Add(row)
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overloads Function AddLUP_DISEASERow(ByVal sDESC As String) As LUP_DISEASERow
            Dim rowLUP_DISEASERow As LUP_DISEASERow = CType(Me.NewRow,LUP_DISEASERow)
            rowLUP_DISEASERow.ItemArray = New Object() {Nothing, sDESC}
            Me.Rows.Add(rowLUP_DISEASERow)
            Return rowLUP_DISEASERow
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function FindBynCODE(ByVal nCODE As Decimal) As LUP_DISEASERow
            Return CType(Me.Rows.Find(New Object() {nCODE}),LUP_DISEASERow)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overridable Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overrides Function Clone() As System.Data.DataTable
            Dim cln As LUP_DISEASEDataTable = CType(MyBase.Clone,LUP_DISEASEDataTable)
            cln.InitVars
            Return cln
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Function CreateInstance() As System.Data.DataTable
            Return New LUP_DISEASEDataTable
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Friend Sub InitVars()
            Me.columnnCODE = MyBase.Columns("nCODE")
            Me.columnsDESC = MyBase.Columns("sDESC")
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Private Sub InitClass()
            Me.columnnCODE = New System.Data.DataColumn("nCODE", GetType(Decimal), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnnCODE)
            Me.columnsDESC = New System.Data.DataColumn("sDESC", GetType(String), Nothing, System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnsDESC)
            Me.Constraints.Add(New System.Data.UniqueConstraint("Constraint1", New System.Data.DataColumn() {Me.columnnCODE}, true))
            Me.columnnCODE.AutoIncrement = true
            Me.columnnCODE.AllowDBNull = false
            Me.columnnCODE.ReadOnly = true
            Me.columnnCODE.Unique = true
            Me.columnsDESC.AllowDBNull = false
            Me.columnsDESC.MaxLength = 50
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function NewLUP_DISEASERow() As LUP_DISEASERow
            Return CType(Me.NewRow,LUP_DISEASERow)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Function NewRowFromBuilder(ByVal builder As System.Data.DataRowBuilder) As System.Data.DataRow
            Return New LUP_DISEASERow(builder)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(LUP_DISEASERow)
        End Function
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowChanged(ByVal e As System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.LUP_DISEASERowChangedEvent) Is Nothing) Then
                RaiseEvent LUP_DISEASERowChanged(Me, New LUP_DISEASERowChangeEvent(CType(e.Row,LUP_DISEASERow), e.Action))
            End If
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowChanging(ByVal e As System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.LUP_DISEASERowChangingEvent) Is Nothing) Then
                RaiseEvent LUP_DISEASERowChanging(Me, New LUP_DISEASERowChangeEvent(CType(e.Row,LUP_DISEASERow), e.Action))
            End If
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowDeleted(ByVal e As System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.LUP_DISEASERowDeletedEvent) Is Nothing) Then
                RaiseEvent LUP_DISEASERowDeleted(Me, New LUP_DISEASERowChangeEvent(CType(e.Row,LUP_DISEASERow), e.Action))
            End If
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowDeleting(ByVal e As System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.LUP_DISEASERowDeletingEvent) Is Nothing) Then
                RaiseEvent LUP_DISEASERowDeleting(Me, New LUP_DISEASERowChangeEvent(CType(e.Row,LUP_DISEASERow), e.Action))
            End If
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub RemoveLUP_DISEASERow(ByVal row As LUP_DISEASERow)
            Me.Rows.Remove(row)
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Shared Function GetTypedTableSchema(ByVal xs As System.Xml.Schema.XmlSchemaSet) As System.Xml.Schema.XmlSchemaComplexType
            Dim type As System.Xml.Schema.XmlSchemaComplexType = New System.Xml.Schema.XmlSchemaComplexType
            Dim sequence As System.Xml.Schema.XmlSchemaSequence = New System.Xml.Schema.XmlSchemaSequence
            Dim ds As dsLUP_DISEASE = New dsLUP_DISEASE
            xs.Add(ds.GetSchemaSerializable)
            Dim any1 As System.Xml.Schema.XmlSchemaAny = New System.Xml.Schema.XmlSchemaAny
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As System.Xml.Schema.XmlSchemaAny = New System.Xml.Schema.XmlSchemaAny
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As System.Xml.Schema.XmlSchemaAttribute = New System.Xml.Schema.XmlSchemaAttribute
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As System.Xml.Schema.XmlSchemaAttribute = New System.Xml.Schema.XmlSchemaAttribute
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "LUP_DISEASEDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Return type
        End Function
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")>  _
    Partial Public Class LUP_DISEASERow
        Inherits System.Data.DataRow
        
        Private tableLUP_DISEASE As LUP_DISEASEDataTable
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Friend Sub New(ByVal rb As System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableLUP_DISEASE = CType(Me.Table,LUP_DISEASEDataTable)
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property nCODE() As Decimal
            Get
                Return CType(Me(Me.tableLUP_DISEASE.nCODEColumn),Decimal)
            End Get
            Set
                Me(Me.tableLUP_DISEASE.nCODEColumn) = value
            End Set
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property sDESC() As String
            Get
                Return CType(Me(Me.tableLUP_DISEASE.sDESCColumn),String)
            End Get
            Set
                Me(Me.tableLUP_DISEASE.sDESCColumn) = value
            End Set
        End Property
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")>  _
    Public Class LUP_DISEASERowChangeEvent
        Inherits System.EventArgs
        
        Private eventRow As LUP_DISEASERow
        
        Private eventAction As System.Data.DataRowAction
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub New(ByVal row As LUP_DISEASERow, ByVal action As System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property Row() As LUP_DISEASERow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property Action() As System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
