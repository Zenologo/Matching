Imports LibMetier.EnumerationsMetier

Namespace LibRechProfil
    Public Class entite

        Public Class critereRMC
            Public Code As Integer
            Public Libelle As String
            Public Type As RechercheProfil.TypeCritere
            Public OperateurAutorise As List(Of EnumerationsMetier.RechercheProfil.Operateur)
        End Class

        Public Class lienCritereOperateurRMC
            Friend id As Integer
            Public id_Critere As Integer
            Public id_Operateur As EnumerationsMetier.RechercheProfil.Operateur
        End Class

        Public Class Droit_Acces_RechProfil

            Private mCvtheque As Cvtheque
            Public Overridable Property CvTheque() As Cvtheque
                Get
                    Return Me.mCvtheque
                End Get
                Protected Friend Set(ByVal value As Cvtheque)
                    Me.mCvtheque = value
                End Set
            End Property

        End Class

        Public Class Cvtheque
            Public ListeCpGrandeVille As List(Of String)

            Public IsRechercheGeoLoc As Boolean
            Public AutoriseCritereCompetence As Boolean
            Public UrlWebService As String

        End Class


        Public Class MappingVacancy
            Private _language As String
            Public Overridable Property language() As String
                Get
                    Return Me._language
                End Get
                Set(value As String)
                    Me._language = value
                End Set
            End Property

            Private _job_title As String
            Public Overridable Property job_title() As String
                Get
                    Return Me._job_title
                End Get
                Set(value As String)
                    Me._job_title = value
                End Set
            End Property

            Private _location As String
            Public Overridable Property location As String
                Get
                    Return Me._location
                End Get
                Set(value As String)
                    Me._location = value
                End Set
            End Property

            Private _reference_number As String
            Public Overridable Property reference_number As String
                Get
                    Return Me._reference_number
                End Get
                Set(value As String)
                    Me._reference_number = value
                End Set
            End Property

            Private _posting_date As String
            Public Overridable Property posting_date As String
                Get
                    Return Me._posting_date
                End Get
                Set(value As String)
                    Me._posting_date = value
                End Set
            End Property

            Private _application_deadline As String
            Public Overridable Property application_deadline As String
                Get
                    Return Me._application_deadline
                End Get
                Set(value As String)
                    Me._application_deadline = value
                End Set
            End Property

            Private _start_date As String
            Public Overridable Property start_date As String
                Get
                    Return Me._start_date
                End Get
                Set(value As String)
                    Me._start_date = value
                End Set
            End Property

            Private _number_of_opening As String
            Public Overridable Property number_of_opening As String
                Get
                    Return Me._number_of_opening
                End Get
                Set(value As String)
                    Me._number_of_opening = value
                End Set
            End Property


            Public Class OrganizationReferentiel
                Private _name As String
                Public Overridable Property name As String
                    Get
                        Return Me._name
                    End Get
                    Set(value As String)
                        Me._name = value
                    End Set
                End Property

                Private _addresse As String
                Public Overridable Property addresse As String
                    Get
                        Return Me._addresse
                    End Get
                    Set(value As String)
                        Me._addresse = value
                    End Set
                End Property

                Private _phone As String
                Public Overridable Property phone As String
                    Get
                        Return Me._phone
                    End Get
                    Set(value As String)
                        Me._phone = value
                    End Set
                End Property

                Private _email As String
                Public Overridable Property email As String
                    Get
                        Return Me._email
                    End Get
                    Set(value As String)
                        Me._email = value
                    End Set
                End Property

                Private _fax As String
                Public Overridable Property fax As String
                    Get
                        Return Me._fax
                    End Get
                    Set(value As String)
                        Me._fax = value
                    End Set
                End Property

                Private _website As String
                Public Overridable Property website As String
                    Get
                        Return Me._website
                    End Get
                    Set(value As String)
                        Me._website = value
                    End Set
                End Property

                Private _contact_person As String
                Public Overridable Property contact_person As String
                    Get
                        Return Me._contact_person
                    End Get
                    Set(value As String)
                        Me._contact_person = value
                    End Set
                End Property

                Private _industry As String
                Public Overridable Property industry As String
                    Get
                        Return Me._industry
                    End Get
                    Set(value As String)
                        Me._industry = value
                    End Set
                End Property

            End Class

            Private _organization As OrganizationReferentiel
            Public Overridable Property organization As OrganizationReferentiel
                Get
                    Return Me._organization
                End Get
                Set(value As OrganizationReferentiel)
                    Me._organization = value
                End Set
            End Property

            Public Class candidateRequirements
                Private _experience As String
                Public Overridable Property experience As String
                    Get
                        Return Me._experience
                    End Get
                    Set(value As String)
                        Me._experience = value
                    End Set
                End Property

                Private _education As String
                Public Overridable Property education As String
                    Get
                        Return Me._education
                    End Get
                    Set(value As String)
                        Me._education = value
                    End Set
                End Property

                Private _competences As String
                Public Overridable Property competences As String
                    Get
                        Return Me._competences
                    End Get
                    Set(value As String)
                        Me._competences = value
                    End Set
                End Property

                Private _computer_skills As String
                Public Overridable Property computer_skills As String
                    Get
                        Return Me._computer_skills
                    End Get
                    Set(value As String)
                        Me._computer_skills = value
                    End Set
                End Property

                Private _driving_licenses As String
                Public Overridable Property driving_licenses As String
                    Get
                        Return Me._driving_licenses
                    End Get
                    Set(value As String)
                        Me._driving_licenses = value
                    End Set
                End Property


                Private _language_skills As String
                Public Overridable Property language_skills As String
                    Get
                        Return Me._language_skills
                    End Get
                    Set(value As String)
                        Me._language_skills = value
                    End Set
                End Property
            End Class

            Private _condidate_requirements As candidateRequirements
            Public Overridable Property condidate_requirements As candidateRequirements
                Get
                    Return Me._condidate_requirements
                End Get
                Set(value As candidateRequirements)
                    Me._condidate_requirements = value
                End Set
            End Property


            Public Class ConditionsBenefits
                Private _contract_type As String
                Public Overridable Property contract_type As String
                    Get
                        Return Me._contract_type
                    End Get
                    Set(value As String)
                        Me._contract_type = value
                    End Set
                End Property

                Private _employment_type As String
                Public Overridable Property employment_type As String
                    Get
                        Return Me._employment_type
                    End Get
                    Set(value As String)
                        Me._employment_type = value
                    End Set
                End Property

                Private _hours_per_week As String
                Public Overridable Property hours_per_week As String
                    Get
                        Return Me._hours_per_week
                    End Get
                    Set(value As String)
                        Me._hours_per_week = value
                    End Set
                End Property

                Private _working_hours As String
                Public Overridable Property working_hours As String
                    Get
                        Return Me._working_hours
                    End Get
                    Set(value As String)
                        Me._working_hours = value
                    End Set
                End Property

                Private _salary As String
                Public Overridable Property salary As String
                    Get
                        Return Me._salary
                    End Get
                    Set(value As String)
                        Me._salary = value
                    End Set
                End Property
            End Class

            Private _conditions_benefits As ConditionsBenefits
            Public Overridable Property conditions_benefits As ConditionsBenefits
                Get
                    Return Me._conditions_benefits
                End Get
                Set(value As ConditionsBenefits)
                    Me._conditions_benefits = value
                End Set
            End Property


            Public Class SectionsReferentiel
                Private _employer_description As String
                Public Overridable Property employer_description As String
                    Get
                        Return Me._employer_description
                    End Get
                    Set(value As String)
                        Me._employer_description = value
                    End Set
                End Property

                Private _job_description As String
                Public Overridable Property job_description As String
                    Get
                        Return Me._job_description
                    End Get
                    Set(value As String)
                        Me._job_description = value
                    End Set
                End Property

                Private _candidate_profile As String
                Public Overridable Property candidate_profile As String
                    Get
                        Return Me._candidate_profile
                    End Get
                    Set(value As String)
                        Me._candidate_profile = value
                    End Set
                End Property

                Private _conditions_benefits As String
                Public Overridable Property conditions_benefis As String
                    Get
                        Return Me._conditions_benefits
                    End Get
                    Set(value As String)
                        Me._conditions_benefits = value
                    End Set
                End Property

                Private _application_procedure As String
                Public Overridable Property application_procedure As String
                    Get
                        Return Me._application_procedure
                    End Get
                    Set(value As String)
                        Me._application_procedure = value
                    End Set
                End Property
            End Class

            Private _sections As SectionsReferentiel
            Public Overridable Property sections As SectionsReferentiel
                Get
                    Return Me._sections
                End Get
                Set(value As SectionsReferentiel)
                    Me._sections = value
                End Set
            End Property

            Private _vacancy_text As String
            Public Overridable Property vacancy_text As String
                Get
                    Return Me._vacancy_text
                End Get
                Set(value As String)
                    Me._vacancy_text = value
                End Set
            End Property

            Public Class userArea

                Private _dossier_complet As CritereFlag
                Public Overridable Property dossier_complet As CritereFlag
                    Get
                        Return Me._dossier_complet
                    End Get
                    Set(value As CritereFlag)
                        Me._dossier_complet = value
                    End Set
                End Property

                Private _qualification As CritereReferentiel
                Public Overridable Property qualification() As CritereReferentiel
                    Get
                        Return Me._qualification
                    End Get
                    Set(value As CritereReferentiel)
                        Me._qualification = value
                    End Set
                End Property

                Private _contract_type As CritereReferentiel
                Public Overridable Property contract_type As CritereReferentiel
                    Get
                        Return Me._contract_type
                    End Get
                    Set(value As CritereReferentiel)
                        Me._contract_type = value
                    End Set
                End Property

                Private _niveau_etude As CritereReferentiel
                Public Overridable Property niveau_etude As CritereReferentiel
                    Get
                        Return Me._niveau_etude
                    End Get
                    Set(value As CritereReferentiel)
                        Me._niveau_etude = value
                    End Set
                End Property

                Private _metier As CritereReferentiel
                Public Overridable Property metier As CritereReferentiel
                    Get
                        Return Me._metier
                    End Get
                    Set(value As CritereReferentiel)
                        Me._metier = value
                    End Set
                End Property

                Public mobilite() As CritereReferentiel

                Private _date_debut As CritereDate
                Public Overridable Property date_debut As CritereDate
                    Get
                        Return Me._date_debut
                    End Get
                    Set(value As CritereDate)
                        Me._date_debut = value
                    End Set
                End Property

                Private _date_fin As CritereDate
                Public Overridable Property date_fin As CritereDate
                    Get
                        Return Me._date_fin
                    End Get
                    Set(value As CritereDate)
                        Me._date_fin = value
                    End Set
                End Property

                Private _permis As CritereReferentiel
                Public Overridable Property permis As CritereReferentiel
                    Get
                        Return Me._permis
                    End Get
                    Set(value As CritereReferentiel)
                        Me._permis = value
                    End Set
                End Property

                Public competence() As CritereReferentiel

                Private _annees_experience As CritereFloat
                Public Overridable Property annees_experience As CritereFloat
                    Get
                        Return Me._annees_experience
                    End Get
                    Set(value As CritereFloat)
                        Me._annees_experience = value
                    End Set
                End Property

                Private _client As CritereReferentiel
                Public Overridable Property client As CritereReferentiel
                    Get
                        Return Me._client
                    End Get
                    Set(value As CritereReferentiel)
                        Me._client = value
                    End Set
                End Property


                Private _secteur As CritereReferentiel
                Public Overridable Property secteur As CritereReferentiel
                    Get
                        Return Me._secteur
                    End Get
                    Set(value As CritereReferentiel)
                        Me._secteur = value
                    End Set
                End Property

                Private _service As CritereReferentiel
                Public Overridable Property service As CritereReferentiel
                    Get
                        Return Me._service
                    End Get
                    Set(value As CritereReferentiel)
                        Me._service = value
                    End Set
                End Property

                Private _regroupement As CritereReferentiel
                Public Overridable Property regroupement As CritereReferentiel
                    Get
                        Return Me._regroupement
                    End Get
                    Set(value As CritereReferentiel)
                        Me._regroupement = value
                    End Set
                End Property


                Public Class DiplomeReferentiel
                    Private _code As String
                    Public Overridable Property code() As String
                        Get
                            Return Me._code
                        End Get
                        Set(value As String)
                            Me._code = value
                        End Set
                    End Property

                    Private _libelle As String
                    Public Overridable Property libelle() As String
                        Get
                            Return Me._libelle
                        End Get
                        Set(value As String)
                            Me._libelle = value
                        End Set
                    End Property

                    Private _priorite As Integer
                    Public Overridable Property priorite As Integer
                        Get
                            Return Me._priorite
                        End Get
                        Set(value As Integer)
                            Me._priorite = value
                        End Set
                    End Property

                    Private _obtenu As Integer
                    Public Overridable Property obtenu As Integer
                        Get
                            Return Me._obtenu
                        End Get
                        Set(value As Integer)
                            Me._obtenu = value
                        End Set
                    End Property
                End Class
                Private _diplome As DiplomeReferentiel


                Public habilitation() As HabilitationReferentiel

                Public langue() As CritereReferentiel

                Private _visite_medicale_a_jour As CritereDate
                Public Overridable Property visite_medicale_a_jour As CritereDate
                    Get
                        Return Me._visite_medicale_a_jour
                    End Get
                    Set(value As CritereDate)
                        Me._visite_medicale_a_jour = value
                    End Set
                End Property

                Private _statut_cdi_tt As CritereFlag
                Public Overridable Property statut_cdi_tt As CritereFlag
                    Get
                        Return Me._statut_cdi_tt
                    End Get
                    Set(value As CritereFlag)
                        Me._statut_cdi_tt = value
                    End Set
                End Property

                Private _tt_400h As CritereFlag
                Public Overridable Property tt_400h As CritereFlag
                    Get
                        Return Me._tt_400h
                    End Get
                    Set(value As CritereFlag)
                        Me._tt_400h = value
                    End Set
                End Property

                Private _fspi As CritereFlag
                Public Overridable Property fspi As CritereFlag
                    Get
                        Return Me._fspi
                    End Get
                    Set(value As CritereFlag)
                        Me._fspi = value
                    End Set
                End Property


                Public Class compteMatching
                    Private _sigle As String

                    Public Overridable Property sigle() As String
                        Get
                            Return Me._sigle
                        End Get
                        Set(value As String)
                            Me._sigle = value
                        End Set
                    End Property

                    Private _matricule_cli As String
                    Public Overridable Property matricule_cli() As String
                        Get
                            Return Me._matricule_cli
                        End Get
                        Set(value As String)
                            Me._matricule_cli = value
                        End Set
                    End Property

                    Private _nom As String
                    Public Overridable Property nom() As String
                        Get
                            Return Me._nom
                        End Get
                        Set(value As String)
                            Me._nom = value
                        End Set
                    End Property

                End Class
                Private _compte As compteMatching
                Public Overridable Property compte() As compteMatching
                    Get
                        Return Me._compte
                    End Get
                    Set(value As compteMatching)
                        Me._compte = value
                    End Set

                End Property



                Private _addresse_delegation As AdresseReferentiel
                Public Overridable Property addresse_delegation As AdresseReferentiel
                    Get
                        Return Me._addresse_delegation
                    End Get
                    Set(value As AdresseReferentiel)
                        Me._addresse_delegation = value
                    End Set
                End Property

                Private _cp_commune As Referentiel
                Public Overridable Property cp_commune As Referentiel
                    Get
                        Return Me._cp_commune
                    End Get
                    Set(value As Referentiel)
                        Me._cp_commune = value
                    End Set
                End Property



                Public Class Referentiel
                    Private _code As String
                    Public Overridable Property code() As String
                        Get
                            Return Me._code
                        End Get
                        Set(value As String)
                            Me._code = value
                        End Set
                    End Property

                    Private _libelle As String
                    Public Overridable Property libelle() As String
                        Get
                            Return Me._libelle
                        End Get
                        Set(value As String)
                            Me._libelle = value
                        End Set
                    End Property

                End Class

                Public Class CritereReferentiel
                    Private _code As String
                    Public Overridable Property code() As String
                        Get
                            Return Me._code
                        End Get
                        Set(value As String)
                            Me._code = value
                        End Set
                    End Property

                    Private _libelle As String
                    Public Overridable Property libelle() As String
                        Get
                            Return Me._libelle
                        End Get
                        Set(value As String)
                            Me._libelle = value
                        End Set
                    End Property

                    Private _priorite As Integer
                    Public Overridable Property priorite As Integer
                        Get
                            Return Me._priorite
                        End Get
                        Set(value As Integer)
                            Me._priorite = value
                        End Set
                    End Property

                End Class

                Public Class CritereFlag
                    Private _flag As Boolean
                    Public Overridable Property flag As Boolean
                        Get
                            Return Me._flag
                        End Get
                        Set(value As Boolean)
                            Me._flag = value
                        End Set
                    End Property

                    Private _priorite As Integer
                    Public Overridable Property priorite As Integer
                        Get
                            Return Me._priorite
                        End Get
                        Set(value As Integer)
                            Me._priorite = value
                        End Set
                    End Property
                End Class

                Public Class CritereFloat
                    Private _nombre As Double
                    Public Overridable Property nombre As Double
                        Get
                            Return Me._nombre
                        End Get
                        Set(value As Double)
                            Me._nombre = value
                        End Set
                    End Property

                    Private _priorite As Integer
                    Public Overridable Property priorite As Integer
                        Get
                            Return Me._priorite
                        End Get
                        Set(value As Integer)
                            Me._priorite = value
                        End Set
                    End Property

                End Class

                Public Class CritereDate
                    Private _date_critere As Date
                    Public Overridable Property date_critere As Date
                        Get
                            Return Me._date_critere
                        End Get
                        Set(value As Date)
                            Me._date_critere = value
                        End Set
                    End Property

                    Private _priorite As Integer
                    Public Overridable Property priorite As Integer
                        Get
                            Return Me._priorite
                        End Get
                        Set(value As Integer)
                            Me._priorite = value
                        End Set
                    End Property
                End Class

                Public Class HabilitationReferentiel
                    Private _code As String
                    Public Overridable Property code() As String
                        Get
                            Return Me._code
                        End Get
                        Set(value As String)
                            Me._code = value
                        End Set
                    End Property

                    Private _libelle As String
                    Public Overridable Property libelle() As String
                        Get
                            Return Me._libelle
                        End Get
                        Set(value As String)
                            Me._libelle = value
                        End Set
                    End Property

                    Private _priorite As Integer
                    Public Overridable Property priorite As Integer
                        Get
                            Return Me._priorite
                        End Get
                        Set(value As Integer)
                            Me._priorite = value
                        End Set
                    End Property

                    Private _date_de_validite As Date
                    Public Overridable Property date_de_validite As Date
                        Get
                            Return Me._date_de_validite
                        End Get
                        Set(value As Date)
                            Me._date_de_validite = value
                        End Set
                    End Property
                End Class


                Public Class AdresseReferentiel
                    Private _ligne1 As String
                    Public Overridable Property ligne1() As String
                        Get
                            Return Me._ligne1
                        End Get
                        Set(value As String)
                            Me._ligne1 = value
                        End Set
                    End Property

                    Private _ligne2 As String
                    Public Overridable Property ligne2() As String
                        Get
                            Return Me._ligne2
                        End Get
                        Set(value As String)
                            Me._ligne2 = value
                        End Set
                    End Property


                    Private _ligne3 As String
                    Public Overridable Property ligne3() As String
                        Get
                            Return Me._ligne3
                        End Get
                        Set(value As String)
                            Me._ligne3 = value
                        End Set
                    End Property

                    Private _ligne4 As String
                    Public Overridable Property ligne4() As String
                        Get
                            Return Me._ligne4
                        End Get
                        Set(value As String)
                            Me._ligne4 = value
                        End Set
                    End Property

                    Private _latitude As String
                    Public Overridable Property latitude As String
                        Get
                            Return Me._latitude
                        End Get
                        Set(value As String)
                            Me._latitude = value
                        End Set
                    End Property

                    Private _longitude As String
                    Public Overridable Property longitude As String
                        Get
                            Return Me._latitude
                        End Get
                        Set(value As String)
                            Me._longitude = value
                        End Set
                    End Property

                    Private _priorite As Integer
                    Public Overridable Property priorite As Integer
                        Get
                            Return Me._priorite
                        End Get
                        Set(value As Integer)
                            Me._priorite = value
                        End Set
                    End Property
                End Class

            End Class 'userArea

            Private _user_area As userArea
            Public Overridable Property user_area As userArea
                Get
                    Return Me._user_area
                End Get
                Set(value As userArea)
                    Me._user_area = value
                End Set
            End Property


        End Class ' calss mappingVacancy





        Public Class MappingMaching
            Public Class compteMatching
                Private _sigle As String

                Public Overridable Property sigle() As String
                    Get
                        Return Me._sigle
                    End Get
                    Set(value As String)
                        Me._sigle = value
                    End Set
                End Property

                Private _matricule_client As String
                Public Overridable Property matricule_client() As String
                    Get
                        Return Me._matricule_client
                    End Get
                    Set(value As String)
                        Me._matricule_client = value
                    End Set
                End Property

                Private _nom As String
                Public Overridable Property nom() As String
                    Get
                        Return Me._nom
                    End Get
                    Set(value As String)
                        Me._nom = value
                    End Set
                End Property

            End Class

            Public Class missionMatching

                Private _metier As CritereReferentiel

                Public Overridable Property metier() As CritereReferentiel
                    Get
                        Return Me._metier
                    End Get
                    Set(value As CritereReferentiel)
                        Me._metier = value
                    End Set
                End Property


                Private _qualification As CritereReferentiel
                Public Overridable Property qualification() As CritereReferentiel
                    Get
                        Return Me._qualification
                    End Get
                    Set(value As CritereReferentiel)
                        Me._qualification = value
                    End Set
                End Property

                Private _adresse_delegation As Adresse
                Public Overridable Property adresse_delegation As Adresse
                    Get
                        Return Me._adresse_delegation
                    End Get
                    Set(value As Adresse)
                        Me._adresse_delegation = value
                    End Set
                End Property

                Private _mobilite As String
                Public Overridable Property mobilite As String
                    Get
                        Return Me._mobilite
                    End Get
                    Set(value As String)
                        Me._mobilite = value
                    End Set
                End Property

                Private _type_contrat As CritereReferentiel
                Public Overridable Property type_contrat As CritereReferentiel
                    Get
                        Return Me._type_contrat
                    End Get
                    Set(value As CritereReferentiel)
                        Me._type_contrat = value
                    End Set
                End Property

                Private _date_debut As CritereDate
                Public Overridable Property date_debut As CritereDate
                    Get
                        Return Me._date_debut
                    End Get
                    Set(value As CritereDate)
                        Me._date_debut = value
                    End Set
                End Property

                Private _date_fin As CritereDate
                Public Overridable Property date_fin As CritereDate
                    Get
                        Return Me._date_fin
                    End Get
                    Set(value As CritereDate)
                        Me._date_fin = value
                    End Set
                End Property

                Private _salaire As String
                Public Overridable Property salaire As String
                    Get
                        Return Me._salaire
                    End Get
                    Set(value As String)
                        Me._salaire = value
                    End Set
                End Property

                Private _taches_realiser As String
                Public Overridable Property taches_realiser As String
                    Get
                        Return Me._taches_realiser
                    End Get
                    Set(value As String)
                        Me._taches_realiser = value
                    End Set
                End Property

                Private _mots_cles As String
                Public Overridable Property mots_cles As String
                    Get
                        Return Me._mots_cles
                    End Get
                    Set(value As String)
                        Me._mots_cles = value
                    End Set
                End Property


            End Class

            Public Class profileMatching
                Private _descriptif As String
                Public Overridable Property descriptif As String
                    Get
                        Return Me._descriptif
                    End Get
                    Set(value As String)
                        Me._descriptif = value
                    End Set
                End Property

                Private _experience As Experience
                Public Overridable Property experience As Experience
                    Get
                        Return Me._experience
                    End Get
                    Set(value As Experience)
                        Me._experience = value
                    End Set
                End Property

                Private _formation As Formation
                Public Overridable Property formation As Formation
                    Get
                        Return Me._formation
                    End Get
                    Set(value As Formation)
                        Me._formation = value
                    End Set
                End Property

                Private _competence As CompetenceMatching
                Public Overridable Property competence As CompetenceMatching
                    Get
                        Return Me._competence
                    End Get
                    Set(value As CompetenceMatching)
                        Me._competence = value
                    End Set
                End Property
            End Class

            Public Class posteMatching
                Private _descriptif_poste As String
                Public Overridable Property descriptif_poste As String
                    Get
                        Return Me._descriptif_poste
                    End Get
                    Set(value As String)
                        Me._descriptif_poste = value
                    End Set
                End Property

                Private _visite_medicale As CritereDate
                Public Overridable Property visite_medicale As CritereDate
                    Get
                        Return Me._visite_medicale
                    End Get
                    Set(value As CritereDate)
                        Me._visite_medicale = value
                    End Set
                End Property
            End Class

            Public Class agenceMatching
                Private _statut_cdi As CritereFlag
                Public Overridable Property statut_cdi As CritereFlag
                    Get
                        Return Me._statut_cdi
                    End Get
                    Set(value As CritereFlag)
                        Me._statut_cdi = value
                    End Set
                End Property

                Private _tt_400h As CritereFlag
                Public Overridable Property tt_400h As CritereFlag
                    Get
                        Return Me._tt_400h
                    End Get
                    Set(value As CritereFlag)
                        Me._tt_400h = value
                    End Set
                End Property

                Private _fspi As String
                Public Overridable Property fspi As String
                    Get
                        Return Me._fspi
                    End Get
                    Set(value As String)
                        Me._fspi = value
                    End Set
                End Property
            End Class




            Public Class CompetenceMatching

                Public Activites() As ActiviteMatching

                Public Machines() As MachineMatching

                Public Domaines() As DomaineMatching

                Public Techniques() As TechniquesMatching

                Private _autre_techniques As String
                Public Overridable Property autre_techniques As String
                    Get
                        Return Me._autre_techniques
                    End Get
                    Set(value As String)
                        Me._autre_techniques = value
                    End Set
                End Property

                Private _comportementales As String
                Public Overridable Property comportementales As String
                    Get
                        Return Me._comportementales
                    End Get
                    Set(value As String)
                        Me._comportementales = value
                    End Set
                End Property

            End Class

            Public Class ActiviteMatching
                Private _priorite As Integer
                Public Overridable Property priorite() As Integer
                    Get
                        Return Me._priorite
                    End Get
                    Set(value As Integer)
                        Me._priorite = value
                    End Set
                End Property

                Private _referentiel As Referentiel
                Public Overridable Property referentiel() As Referentiel
                    Get
                        Return Me._referentiel
                    End Get
                    Set(value As Referentiel)
                        Me._referentiel = value
                    End Set
                End Property

            End Class

            Public Class MachineMatching
                Private _priorite As Integer
                Public Overridable Property priorite() As Integer
                    Get
                        Return Me._priorite
                    End Get
                    Set(value As Integer)
                        Me._priorite = value
                    End Set
                End Property

                Private _referentiel As Referentiel
                Public Overridable Property referentiel() As Referentiel
                    Get
                        Return Me._referentiel
                    End Get
                    Set(value As Referentiel)
                        Me._referentiel = value
                    End Set
                End Property

            End Class

            Public Class DomaineMatching
                Private _priorite As Integer
                Public Overridable Property priorite() As Integer
                    Get
                        Return Me._priorite
                    End Get
                    Set(value As Integer)
                        Me._priorite = value
                    End Set
                End Property

                Private _referentiel As Referentiel
                Public Overridable Property referentiel() As Referentiel
                    Get
                        Return Me._referentiel
                    End Get
                    Set(value As Referentiel)
                        Me._referentiel = value
                    End Set
                End Property

            End Class

            Public Class TechniquesMatching
                Private _priorite As Integer
                Public Overridable Property priorite() As Integer
                    Get
                        Return Me._priorite
                    End Get
                    Set(value As Integer)
                        Me._priorite = value
                    End Set
                End Property

                Private _referentiel As Referentiel
                Public Overridable Property referentiel() As Referentiel
                    Get
                        Return Me._referentiel
                    End Get
                    Set(value As Referentiel)
                        Me._referentiel = value
                    End Set
                End Property

            End Class


            Private _compte As compteMatching
            Public Overridable Property compte() As compteMatching
                Get
                    Return Me._compte
                End Get
                Set(value As compteMatching)
                    Me._compte = value
                End Set

            End Property


            Private _mission As missionMatching
            Public Overridable Property mission() As missionMatching
                Get
                    Return Me._mission
                End Get
                Set(value As missionMatching)
                    Me._mission = value
                End Set
            End Property



            Private _profil As profileMatching
            Public Overridable Property profil As profileMatching
                Get
                    Return Me._profil
                End Get
                Set(value As profileMatching)
                    Me._profil = value
                End Set
            End Property


            Private _poste As posteMatching
            Public Overridable Property poste As posteMatching
                Get
                    Return Me._poste
                End Get
                Set(value As posteMatching)
                    Me._poste = value
                End Set
            End Property

            Private _agence As agenceMatching
            Public Overridable Property agence As agenceMatching
                Get
                    Return Me._agence
                End Get
                Set(value As agenceMatching)
                    Me._agence = value
                End Set
            End Property




            Public Class Referentiel
                Private _code As String
                Public Overridable Property code() As String
                    Get
                        Return Me._code
                    End Get
                    Set(value As String)
                        Me._code = value
                    End Set
                End Property

                Private _libelle As String
                Public Overridable Property libelle() As String
                    Get
                        Return Me._libelle
                    End Get
                    Set(value As String)
                        Me._libelle = value
                    End Set
                End Property

            End Class

            Public Class CritereReferentiel

                Private _referentiel As Referentiel
                Public Overridable Property referentiel() As Referentiel
                    Get
                        Return Me._referentiel
                    End Get
                    Set(value As Referentiel)
                        Me._referentiel = value
                    End Set
                End Property

                Private _priorite As Integer
                Public Overridable Property priorite As Integer
                    Get
                        Return Me._priorite
                    End Get
                    Set(value As Integer)
                        Me._priorite = value
                    End Set
                End Property

            End Class

            Public Class Adresse
                Private _ligne1 As String
                Public Overridable Property ligne1() As String
                    Get
                        Return Me._ligne1
                    End Get
                    Set(value As String)
                        Me._ligne1 = value
                    End Set
                End Property

                Private _ligne2 As String
                Public Overridable Property ligne2() As String
                    Get
                        Return Me._ligne2
                    End Get
                    Set(value As String)
                        Me._ligne2 = value
                    End Set
                End Property


                Private _ligne3 As String
                Public Overridable Property ligne3() As String
                    Get
                        Return Me._ligne3
                    End Get
                    Set(value As String)
                        Me._ligne3 = value
                    End Set
                End Property

                Private _ligne4 As String
                Public Overridable Property ligne4() As String
                    Get
                        Return Me._ligne4
                    End Get
                    Set(value As String)
                        Me._ligne4 = value
                    End Set
                End Property

                Private _cp_commune As Referentiel
                Public Overridable Property cp_commune As Referentiel
                    Get
                        Return Me._cp_commune
                    End Get
                    Set(value As Referentiel)
                        Me._cp_commune = value
                    End Set
                End Property
            End Class

            Public Class CritereDate
                Private _date_critere As Date
                Public Overridable Property date_critere As Date
                    Get
                        Return Me._date_critere
                    End Get
                    Set(value As Date)
                        Me._date_critere = value
                    End Set
                End Property

                Private _priorite As Integer
                Public Overridable Property priorite As Integer
                    Get
                        Return Me._priorite
                    End Get
                    Set(value As Integer)
                        Me._priorite = value
                    End Set
                End Property
            End Class


            Public Class CritereFlag
                Private _flag As Boolean
                Public Overridable Property flag As Boolean
                    Get
                        Return Me._flag
                    End Get
                    Set(value As Boolean)
                        Me._flag = value
                    End Set
                End Property

                Private _priorite As Integer
                Public Overridable Property priorite As Integer
                    Get
                        Return Me._priorite
                    End Get
                    Set(value As Integer)
                        Me._priorite = value
                    End Set
                End Property
            End Class

            Public Class CritereFloat
                Private _nombre As Double
                Public Overridable Property nombre As Double
                    Get
                        Return Me._nombre
                    End Get
                    Set(value As Double)
                        Me._nombre = value
                    End Set
                End Property

                Private _priorite As Integer
                Public Overridable Property priorite As Integer
                    Get
                        Return Me._priorite
                    End Get
                    Set(value As Integer)
                        Me._priorite = value
                    End Set
                End Property

            End Class

            Public Class Experience
                Private _nombre_experience As CritereFloat
                Public Overridable Property nombre_experience As CritereFloat
                    Get
                        Return Me._nombre_experience
                    End Get
                    Set(value As CritereFloat)
                        Me._nombre_experience = value
                    End Set
                End Property

                Private _experience_client As CritereReferentiel
                Public Overridable Property experience_client As CritereReferentiel
                    Get
                        Return Me._experience_client
                    End Get
                    Set(value As CritereReferentiel)
                        Me._experience_client = value
                    End Set
                End Property

                Private _experience_service As CritereReferentiel
                Public Overridable Property experience_service As CritereReferentiel
                    Get
                        Return Me._experience_service
                    End Get
                    Set(value As CritereReferentiel)
                        Me._experience_service = value
                    End Set
                End Property

                Private _experience_secteur As CritereReferentiel
                Public Overridable Property experience_secteur As CritereReferentiel
                    Get
                        Return Me._experience_secteur
                    End Get
                    Set(value As CritereReferentiel)
                        Me._experience_secteur = value
                    End Set
                End Property

                Private _experience_regroupement As CritereReferentiel
                Public Overridable Property experience_regroupement As CritereReferentiel
                    Get
                        Return Me._experience_regroupement
                    End Get
                    Set(value As CritereReferentiel)
                        Me._experience_regroupement = value
                    End Set
                End Property
            End Class


            Public Class Formation

                Private _niveau_etude As CritereReferentiel
                Public Overridable Property niveau_etude As CritereReferentiel
                    Get
                        Return Me._niveau_etude
                    End Get
                    Set(value As CritereReferentiel)
                        Me._niveau_etude = value
                    End Set
                End Property


                Private _diplome As Diplome
                Public Overridable Property diplome As Diplome
                    Get
                        Return Me._diplome
                    End Get
                    Set(value As Diplome)
                        Me._diplome = value
                    End Set
                End Property


                Private _habilitation As Habilitation
                Public Overridable Property habilitation As Habilitation
                    Get
                        Return Me._habilitation
                    End Get
                    Set(value As Habilitation)
                        Me._habilitation = value
                    End Set
                End Property


                Private _permis As Permis
                Public Overridable Property permis As Permis
                    Get
                        Return Me._permis
                    End Get
                    Set(value As Permis)
                        Me._permis = value
                    End Set
                End Property

                Private _langues As Langues
                Public Overridable Property langues As Langues
                    Get
                        Return Me._langues
                    End Get
                    Set(value As Langues)
                        Me._langues = value
                    End Set
                End Property

                Private _autre_formation As String
                Public Overridable Property autre_formation As String
                    Get
                        Return Me._autre_formation
                    End Get
                    Set(value As String)
                        Me._autre_formation = value
                    End Set
                End Property



            End Class


            Public Class Diplome
                Private _type_diplome As CritereReferentiel
                Public Overridable Property type_diplome As CritereReferentiel
                    Get
                        Return Me._type_diplome
                    End Get
                    Set(value As CritereReferentiel)
                        Me._type_diplome = value
                    End Set
                End Property

                Private _obtenu As CritereFlag
                Public Overridable Property obtenu As CritereFlag
                    Get
                        Return Me._obtenu
                    End Get
                    Set(value As CritereFlag)
                        Me._obtenu = value
                    End Set
                End Property
            End Class


            Public Class Habilitation
                Private _type_habilitation As CritereReferentiel
                Public Overridable Property type_habilitation As CritereReferentiel
                    Get
                        Return Me._type_habilitation
                    End Get
                    Set(value As CritereReferentiel)
                        Me._type_habilitation = value
                    End Set
                End Property


                Private _date_validite As CritereDate
                Public Overridable Property date_validite As CritereDate
                    Get
                        Return Me._date_validite
                    End Get
                    Set(value As CritereDate)
                        Me._date_validite = value
                    End Set
                End Property
            End Class

            Public Class Permis
                Private _type_permis As CritereReferentiel
                Public Overridable Property type_permis As CritereReferentiel
                    Get
                        Return Me._type_permis
                    End Get
                    Set(value As CritereReferentiel)
                        Me._type_permis = value
                    End Set
                End Property

                Private _date_validite As CritereDate
                Public Overridable Property date_validite As CritereDate
                    Get
                        Return Me._date_validite
                    End Get
                    Set(value As CritereDate)
                        Me._date_validite = value
                    End Set
                End Property

            End Class


            Public Class Langues
                Private _langue As CritereReferentiel
                Public Overridable Property langue As CritereReferentiel
                    Get
                        Return Me._langue
                    End Get
                    Set(value As CritereReferentiel)
                        Me._langue = value
                    End Set
                End Property

                Private _niveau As CritereReferentiel
                Public Overridable Property niveau As CritereReferentiel
                    Get
                        Return Me._niveau
                    End Get
                    Set(value As CritereReferentiel)
                        Me._niveau = value
                    End Set
                End Property
            End Class


        End Class

    End Class

End Namespace


