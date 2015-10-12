Imports classes_xml_generees.LibRechProfil
Imports classes_xml_generees.LibRechProfil.Referentiel

Imports classes_xml_generees.LibRechCandidat
Imports classes_xml_generees.LibRechCandidat.Referentiel






Namespace LibRechProfil

    Public Class matching_candidat

        Private mVacancy As New VACANCY


        Private mLanguage As String

        Private mJobTitle As String

        Private mLocation As String

        Private mReferenceNumber As String

        Private mPostingDate As String

        Private mApplicationDeadline As String

        Private mStartDate As String

        Private mNumberOfOpenings As String

        Private mOrganization As Organization

        Private mCandidateRequirements As CandidateRequirements

        Private mConditionsBenefits As ConditionsBenefits

        Private mSections As Sections

        Private mVacancyText As String

        Private mUserArea As UserArea

        Public Sub New()

        End Sub

        Public Function GetXML(ByVal lMapping As entite.MappingVacancy) As String

            ' languageField As String
            Me.Ajouter_Language(lMapping.language)

            'Private jobTitleField As String
            Me.Ajouter_JobTitle(lMapping.job_title)

            'Private mLocation As String
            Me.Ajouter_Location(lMapping.location)

            'Private mReferenceNumber As String
            Me.Ajouter_ReferenceNumber(lMapping.reference_number)

            'Private mPostingDate As String
            Me.Ajouter_PostingDate(lMapping.posting_date)

            'Private mApplicationDeadline As String
            Me.Ajouter_ApplicationDeadline(lMapping.application_deadline)

            'Private mStartDate As String
            Me.Ajouter_StartDate(lMapping.start_date)

            'Private mNumberOfOpenings As String
            Me.Ajouter_NumberOfOpenings(lMapping.number_of_opening)

            'Private mOrganization As Organization
            Me.Ajouter_Organization_adresse(lMapping.organization.addresse)
            Me.Ajouter_Organization_Name(lMapping.organization.name)
            Me.Ajouter_Organization_Phone(lMapping.organization.phone)
            Me.Ajouter_Organization_Email(lMapping.organization.email)
            Me.Ajouter_Organization_Website(lMapping.organization.website)
            Me.Ajouter_Organization_ContractPerson(lMapping.organization.contact_person)
            Me.Ajouter_Organization_Industry(lMapping.organization.industry)

            'Private mCandidateRequirements As CandidateRequirements

            'Private mConditionsBenefits As ConditionsBenefits

            'Private mSections As Sections

            'Private mVacancyText As String
            Me.mVacancyText = lMapping.vacancy_text

            'Private mUserArea As UserArea
            Me.Ajouter_UserArea_DossierComplet(lMapping.user_area.dossier_complet.priorite, lMapping.user_area.dossier_complet.flag)
            Me.Ajouter_UserArea_Qualification(lMapping.user_area.qualification.code, lMapping.user_area.qualification.libelle, lMapping.user_area.qualification.priorite)
            Me.Ajouter_UserArea_ContractType(lMapping.user_area.contract_type.code, lMapping.user_area.contract_type.libelle, lMapping.user_area.contract_type.priorite)
            Me.Ajouter_UserArea_NiveauEtude(lMapping.user_area.niveau_etude.code, lMapping.user_area.niveau_etude.libelle, lMapping.user_area.niveau_etude.priorite)
            Me.Ajouter_UserArea_Metier(lMapping.user_area.metier.code, lMapping.user_area.metier.libelle, lMapping.user_area.metier.priorite)

            Dim lMobiliteLength = lMapping.user_area.mobilite.Length
            Me.Ajouter_UserArea_Mobilite(lMapping.user_area.mobilite)

            Me.Ajouter_UserArea_DateDebut(lMapping.user_area.date_debut.priorite, lMapping.user_area.date_debut.date_critere)

            Me.ajouter_userArea_Permis(lMapping.user_area.permis.priorite, lMapping.user_area.permis.libelle, lMapping.user_area.permis.code)



            Me.ConsoliderDate()

            Return MthConvertXml.ConvertirObjetEnXMLDocument(mVacancy).OuterXml
        End Function


        Private Sub Ajouter_Language(ByVal language As String)
            Me.mLanguage = language
        End Sub

        Private Sub Ajouter_JobTitle(ByVal jobTitle As String)
            Me.mJobTitle = jobTitle
        End Sub

        Private Sub Ajouter_Location(ByVal location As String)
            Me.mLocation = location
        End Sub


        Private Sub Ajouter_ReferenceNumber(ByVal referenceNumber As String)
            Me.mReferenceNumber = referenceNumber
        End Sub

        Private Sub Ajouter_PostingDate(ByVal postingDate As String)
            Me.mPostingDate = postingDate
        End Sub


        Private Sub Ajouter_ApplicationDeadline(ByVal applicationDeadLine As String)
            Me.mApplicationDeadline = applicationDeadLine
        End Sub

        Private Sub Ajouter_StartDate(ByVal startDate As String)
            Me.mStartDate = startDate
        End Sub

        Private Sub Ajouter_NumberOfOpenings(ByVal numberOfOpening As String)
            Me.mNumberOfOpenings = numberOfOpening
        End Sub

        Private Sub Ajouter_Organization_Name(ByVal name As String)
            Me.mOrganization.Name = name
        End Sub

        Private Sub Ajouter_Organization_adresse(ByVal adresse As String)
            Me.mOrganization.Address = adresse
        End Sub

        Private Sub Ajouter_Organization_Phone(ByVal phone As String)
            Me.mOrganization.Phone = phone
        End Sub

        Private Sub Ajouter_Organization_Email(ByVal email As String)
            Me.mOrganization.Email = email
        End Sub

        Private Sub Ajouter_Organization_Fax(ByVal fax As String)
            Me.mOrganization.Fax = fax
        End Sub

        Private Sub Ajouter_Organization_Website(ByVal website As String)
            Me.mOrganization.Website = website
        End Sub

        Private Sub Ajouter_Organization_ContractPerson(ByVal contractPerson As String)
            Me.mOrganization.ContactPerson = contractPerson
        End Sub

        Private Sub Ajouter_Organization_Industry(ByVal industry As String)
            Me.mOrganization.Industry = industry
        End Sub

        Private Sub Ajouter_UserArea_DossierComplet(ByVal flag As Boolean, ByVal priorite As Integer)
            Me.mUserArea.dossier_complet.priorite = priorite
            Me.mUserArea.dossier_complet.flag = flag
        End Sub

        Private Sub Ajouter_UserArea_Qualification(ByVal code As String, ByVal libelle As String, priorite As Integer)
            Dim lRf As New classes_xml_generees.LibRechCandidat.CritereReferentiel
            lRf.code = code
            lRf.libelle = libelle
            lRf.priorite = priorite

            Me.mUserArea.qualification = lRf
        End Sub

        Private Sub Ajouter_UserArea_ContractType(ByVal code As String, ByVal libelle As String, priorite As Integer)
            Me.mUserArea.contracttype.priorite = priorite
            Me.mUserArea.contracttype.code = code
            Me.mUserArea.contracttype.libelle = libelle
        End Sub

        Private Sub Ajouter_UserArea_NiveauEtude(ByVal code As String, ByVal libelle As String, priorite As Integer)
            Me.mUserArea.niveau_etude.priorite = priorite
            Me.mUserArea.niveau_etude.code = code
            Me.mUserArea.niveau_etude.libelle = libelle
        End Sub

        Private Sub Ajouter_UserArea_Metier(ByVal code As String, ByVal libelle As String, priorite As Integer)
            Me.mUserArea.metier.code = code
            Me.mUserArea.metier.libelle = libelle
            Me.mUserArea.metier.priorite = priorite
        End Sub

        Private Sub Ajouter_UserArea_Mobilite(ByVal mobilites() As entite.MappingVacancy.userArea.CritereReferentiel)
            Dim lMobiliteLength = mobilites.Length
            Dim lMobilite() As classes_xml_generees.LibRechCandidat.CritereReferentiel = New classes_xml_generees.LibRechCandidat.CritereReferentiel(lMobiliteLength) {}
            For index As Integer = 0 To lMobiliteLength - 1
                lMobilite(index) = Me.GetCritereReferentiel(mobilites(index).code, mobilites(index).libelle, mobilites(index).priorite)
            Next

            Me.mUserArea.mobilite = lMobilite
        End Sub

        Private Sub Ajouter_UserArea_DateDebut(ByVal priorite As Integer, ByVal critereDate As Date)
            Me.mUserArea.date_debut = Me.GetCritereDate(critereDate, priorite)
        End Sub

        Private Sub Ajouter_UserArea_Permis(ByVal priorite As Integer, ByVal libelle As String, ByVal code As String)
            Me.mUserArea.permis = Me.GetCritereReferentiel(code, libelle, priorite)
        End Sub









        Private Function GetCritereReferentiel(ByVal pCode As String, ByVal pLibelle As String, ByVal pPriorite As Integer) As classes_xml_generees.LibRechCandidat.CritereReferentiel
            Dim lRef As New classes_xml_generees.LibRechCandidat.CritereReferentiel()
            lRef.priorite = pPriorite
            lRef.code = pCode
            lRef.libelle = pLibelle
            Return lRef
        End Function

        Private Function GetCritereFloat(ByVal pNombre As Single, ByVal pPriorite As Integer) As classes_xml_generees.LibRechCandidat.CritereFloat
            Dim lCritereFloat As New classes_xml_generees.LibRechCandidat.CritereFloat()
            lCritereFloat.nombre = pNombre
            lCritereFloat.nombreSpecified = True
            lCritereFloat.priorite = pPriorite
            lCritereFloat.prioriteSpecified = True
            Return lCritereFloat
        End Function

        Private Function GetCritereDate(ByVal pDate As Date, ByVal pPriorite As Integer) As classes_xml_generees.LibRechCandidat.CritereDate
            Dim lCritereDate As New classes_xml_generees.LibRechCandidat.CritereDate()
            lCritereDate.date = pDate
            lCritereDate.dateSpecified = True
            lCritereDate.priorite = pPriorite
            lCritereDate.prioriteSpecified = True
            Return lCritereDate
        End Function


        Private Function GetCritereFlag(ByVal pflag As Boolean, ByVal pPriorite As Integer) As classes_xml_generees.LibRechCandidat.CritereFlag
            Dim lCritereFlag As New classes_xml_generees.LibRechCandidat.CritereFlag()
            lCritereFlag.flag = pflag
            lCritereFlag.flagSpecified = True
            lCritereFlag.priorite = pPriorite
            lCritereFlag.prioriteSpecified = True
            Return lCritereFlag
        End Function

        Private Function GetCritereReferentiel(ByVal critereReferentiel As classes_xml_generees.LibRechCandidat.CritereReferentiel)
            Dim ref = New classes_xml_generees.LibRechCandidat.CritereReferentiel
            ref.code = critereReferentiel.code
            ref.libelle = critereReferentiel.libelle
            ref.priorite = critereReferentiel.priorite
            Return ref
        End Function

        Private Sub ConsoliderDate()
            mVacancy.Language = mLanguage
        End Sub

    End Class


    '---------------------------------------------------------------------------------------------


    Public Class matching_c

        Private mClient As New CLIENT
        Private mCompte As New Compte
        Private mMission As New Mission

        Private mProfil As New Profil
        Private mPoste As New Poste
        Private mAgence As New Agence



        Public Sub New()

        End Sub

        Public Function GetXML(ByVal lMapping As entite.MappingMaching) As String

            'compte
            Me.Ajouter_Compte_MatriculeClient(lMapping.compte.matricule_client)
            Me.Ajouter_Compte_Nom(lMapping.compte.nom)
            Me.Ajouter_Compte_Sigle(lMapping.compte.sigle)

            ' Mission 
            Me.Ajouter_Mission_Metier(Me.GetCritereReferentiel(lMapping.mission.metier.referentiel.code, lMapping.mission.metier.referentiel.libelle, lMapping.mission.metier.priorite))
            Me.Ajouter_mission_Qualification(Me.GetCritereReferentiel(lMapping.mission.qualification.referentiel.code, lMapping.mission.qualification.referentiel.libelle, lMapping.mission.qualification.priorite))
            Me.Ajouter_Misssion_AdresseDelegation(lMapping.mission.adresse_delegation.ligne1, lMapping.mission.adresse_delegation.ligne2,
                                                  lMapping.mission.adresse_delegation.ligne3,
                                                  lMapping.mission.adresse_delegation.ligne4,
                                                  lMapping.mission.adresse_delegation.cp_commune.code,
                                                  lMapping.mission.adresse_delegation.cp_commune.libelle)
            Me.Ajouter_Mission_Mobilite(lMapping.mission.mobilite)
            Me.Ajouter_Mission_TypeContrat(Me.GetCritereReferentiel(lMapping.mission.type_contrat.referentiel.code,
                                                                    lMapping.mission.type_contrat.referentiel.libelle,
                                                                    lMapping.mission.type_contrat.priorite))
            Me.Ajouter_Mission_DateDebut(Me.GetCritereDate(lMapping.mission.date_debut.date_critere,
                                                           lMapping.mission.date_debut.priorite))
            Me.Ajouter_Mission_DateFin(Me.GetCritereDate(lMapping.mission.date_fin.date_critere, lMapping.mission.date_fin.priorite))
            Me.Ajouter_Mission_Salaire(lMapping.mission.salaire)
            Me.Ajouter_Mission_Taches_Realiser(lMapping.mission.taches_realiser)
            Me.Ajouter_Mission_Mots_Cles(lMapping.mission.mots_cles)

            ' Profil
            Me.Ajouter_Profil_Descriptif_Profil(lMapping.profil.descriptif)


            Dim lExperience As New Experience
            lExperience.nombre_experience = Me.GetCritereFloat(lMapping.profil.experience.nombre_experience.nombre,
                                                               lMapping.profil.experience.nombre_experience.priorite)
            lExperience.experience_client = Me.GetCritereReferentiel(lMapping.profil.experience.experience_client.referentiel.code,
                                                                     lMapping.profil.experience.experience_client.referentiel.libelle,
                                                                     lMapping.profil.experience.experience_client.priorite)
            lExperience.experience_service = Me.GetCritereReferentiel(lMapping.profil.experience.experience_service.referentiel.code,
                                                                      lMapping.profil.experience.experience_service.referentiel.libelle,
                                                                      lMapping.profil.experience.experience_service.priorite)
            lExperience.experience_secteur = Me.GetCritereReferentiel(lMapping.profil.experience.experience_secteur.referentiel.code,
                                                                      lMapping.profil.experience.experience_secteur.referentiel.libelle,
                                                                      lMapping.profil.experience.experience_secteur.priorite)
            lExperience.experience_regroupement = Me.GetCritereReferentiel(lMapping.profil.experience.experience_regroupement.referentiel.code,
                                                                           lMapping.profil.experience.experience_regroupement.referentiel.libelle,
                                                                           lMapping.profil.experience.experience_regroupement.priorite)
            Me.Ajouter_Profil_Experience(lExperience)


            Dim lFormation As New Formation
            lFormation.niveau_etude = Me.GetCritereReferentiel(lMapping.profil.formation.niveau_etude.referentiel.code,
                                                               lMapping.profil.formation.niveau_etude.referentiel.libelle,
                                                               lMapping.profil.formation.niveau_etude.priorite)
            Dim lDiplome As New Diplome
            lDiplome.type_diplome = Me.GetCritereReferentiel(lMapping.profil.formation.diplome.type_diplome.referentiel.code,
                                                             lMapping.profil.formation.diplome.type_diplome.referentiel.libelle,
                                                             lMapping.profil.formation.diplome.type_diplome.priorite)
            lDiplome.obtenu = Me.GetCritereFlag(lMapping.profil.formation.diplome.obtenu.flag,
                                                lMapping.profil.formation.diplome.obtenu.priorite)
            lFormation.diplomes = lDiplome

            Dim lHabilitation As New Habilitation
            lHabilitation.type_habilitation = Me.GetCritereReferentiel(lMapping.profil.formation.habilitation.type_habilitation.referentiel.code,
                                                                       lMapping.profil.formation.habilitation.type_habilitation.referentiel.libelle,
                                                                       lMapping.profil.formation.habilitation.type_habilitation.priorite)
            lHabilitation.date_de_validite = Me.GetCritereDate(lMapping.profil.formation.habilitation.date_validite.date_critere,
                                                                   lMapping.profil.formation.habilitation.date_validite.priorite)
            lFormation.habilitations = lHabilitation

            Me.Ajouter_Profile_Formation(lFormation)


            Dim lCompetence As New Competence

            Dim lActiviteLength = lMapping.profil.competence.Activites.Length
            Dim Activites() As CritereReferentiel = New CritereReferentiel(lActiviteLength) {}
            For lIndex As Integer = 0 To lActiviteLength - 1
                Activites(lIndex) = Me.GetCritereReferentiel(lMapping.profil.competence.Activites(lIndex).referentiel.code,
                                                        lMapping.profil.competence.Activites(lIndex).referentiel.libelle,
                                                        lMapping.profil.competence.Activites(lIndex).priorite)
            Next
            lCompetence.activites = Activites

            Dim lMachineLength = lMapping.profil.competence.Machines.Length
            Dim Machine() As CritereReferentiel = New CritereReferentiel(lMachineLength) {}
            For lIndex As Integer = 0 To lMachineLength - 1
                Machine(lIndex) = Me.GetCritereReferentiel(lMapping.profil.competence.Machines(lIndex).referentiel.code,
                                                           lMapping.profil.competence.Machines(lIndex).referentiel.libelle,
                                                           lMapping.profil.competence.Machines(lIndex).priorite)
            Next
            lCompetence.machiens_et_materiels = Machine

            Dim lDomaineLength = lMapping.profil.competence.Machines.Length
            Dim Domaine() As CritereReferentiel = New CritereReferentiel(lDomaineLength) {}
            For lIndex As Integer = 0 To lDomaineLength - 1
                Domaine(lIndex) = Me.GetCritereReferentiel(lMapping.profil.competence.Domaines(lIndex).referentiel.code,
                                                           lMapping.profil.competence.Domaines(lIndex).referentiel.libelle,
                                                           lMapping.profil.competence.Domaines(lIndex).priorite)
            Next
            lCompetence.domaines_de_mise_en_oeuvre = Domaine

            Dim lTechniqueLength = lMapping.profil.competence.Techniques.Length
            Dim Technique() As CritereReferentiel = New CritereReferentiel(lTechniqueLength) {}
            For lIndex As Integer = 0 To lTechniqueLength - 1
                Technique(lIndex) = Me.GetCritereReferentiel(lMapping.profil.competence.Techniques(lIndex).referentiel.libelle,
                                                             lMapping.profil.competence.Techniques(lIndex).referentiel.code,
                                                             lMapping.profil.competence.Techniques(lIndex).priorite)
            Next
            lCompetence.techniques_et_procedes = Technique


            Me.Ajouter_Profil_Conpetences(lCompetence)

            ' Poste
            Me.Ajouter_Poste_Descriptif(lMapping.poste.descriptif_poste)
            Me.Ajouter_Poste_Visite_Medical(Me.GetCritereDate(lMapping.poste.visite_medicale.date_critere,
                                                                lMapping.poste.visite_medicale.priorite))

            'Agence
            Me.Ajouter_Agence_Statut_Cdi_tt(lMapping.agence.statut_cdi.flag, lMapping.agence.statut_cdi.priorite)
            Me.Ajouter_Agence_TT_400h(lMapping.agence.tt_400h.flag, lMapping.agence.tt_400h.priorite)
            Me.Ajouter_Agence_FSPI(lMapping.agence.fspi)

            Me.ConsoliderData()
            'MthConvertXml.ConvertirObjetEnXMLDocument(lClient)

            Return MthConvertXml.ConvertirObjetEnXMLDocument(mClient).OuterXml
        End Function





        Private Sub Ajouter_Compte_MatriculeClient(ByVal pMatriculeClient As String)
            Me.mCompte.matriculeCli = pMatriculeClient
        End Sub

        Private Sub Ajouter_Compte_Nom(ByVal pNom As String)
            Me.mCompte.nom = pNom
        End Sub

        Private Sub Ajouter_Compte_Sigle(ByVal pSigle As String)
            Me.mCompte.sigle = pSigle
        End Sub

        Private Sub ConsoliderData()
            mClient.Agence = mAgence
            mClient.Compte = mCompte
            mClient.Profil = mProfil
            mClient.Mission = mMission
            mClient.Poste = mPoste
        End Sub



        ' ----------------------------------- Function Mission Begin ---------------------------------------


        Private Sub Ajouter_Mission_Metier(ByVal pCritereReferentiel As CritereReferentiel)
            mMission.metier = pCritereReferentiel
        End Sub

        Private Sub Ajouter_mission_Qualification(ByVal pCritereReferentiel As CritereReferentiel)
            mMission.metier = pCritereReferentiel
        End Sub

        Private Sub Ajouter_Misssion_AdresseDelegation(ByVal pLigne1 As String, ByVal pLigne2 As String, ByVal pLigne3 As String, ByVal pLigne4 As String, ByVal pCode As String, ByVal pLibelle As String)
            Dim lAds As New Adresse
            Dim lCpCommune As New classes_xml_generees.LibRechProfil.Referentiel()
            lCpCommune.code = pCode
            lCpCommune.libelle = pLibelle


            lAds.cp_commune = lCpCommune

            lAds.ligne1 = pLigne1
            lAds.ligne2 = pLigne2
            lAds.ligne3 = pLigne3
            lAds.ligne4 = pLigne4

            mMission.adresse_delegation = lAds

        End Sub

        Private Sub Ajouter_Mission_Mobilite(ByVal pMobilite As String)
            mMission.mobilite = pMobilite
        End Sub

        Private Sub Ajouter_Mission_TypeContrat(ByVal pCritereReferentiel As CritereReferentiel)
            mMission.type_contrat = pCritereReferentiel
        End Sub

        Private Sub Ajouter_Mission_DateDebut(ByVal pDateDebut As CritereDate)
            mMission.date_debut = pDateDebut
        End Sub

        Private Sub Ajouter_Mission_DateFin(ByVal pDateDebut As CritereDate)
            mMission.date_fin = pDateDebut
        End Sub

        Private Sub Ajouter_Mission_Salaire(ByVal pSalaire As String)
            mMission.salaire = pSalaire
        End Sub

        Private Sub Ajouter_Mission_Taches_Realiser(ByVal pTaches As String)
            mMission.taches_a_realiser = pTaches
        End Sub

        Private Sub Ajouter_Mission_Mots_Cles(ByVal pMotCles As String)
            mMission.mots_cles = pMotCles
        End Sub

        ' ----------------------------------- Function  Mission End ---------------------------------------


        ' ------------------------------ Function Profil Begin -------------------------------------------------------


        Private Sub Ajouter_Profil_Descriptif_Profil(ByVal pDescriptif As String)
            mProfil.descriptif_profil = pDescriptif
        End Sub


        Private Sub Ajouter_Profil_Experience(ByVal pExperience As Experience)
            mProfil.experience = pExperience
        End Sub

        Private Sub Ajouter_Profile_Formation(ByVal pFormation As Formation)
            mProfil.formation = pFormation
        End Sub

        Private Sub Ajouter_Profil_Conpetences(ByVal pCompetence As Competence)
            mProfil.competences = pCompetence
        End Sub


        ' ------------------------------ Function Profil Begin -------------------------------------



        ' ------------------------------ Function Poste Begin --------------------------------------

        Private Sub Ajouter_Poste_Descriptif(ByVal pDescriptif As String)
            mPoste.descriptif_poste = pDescriptif
        End Sub

        Private Sub Ajouter_Poste_Visite_Medical(ByVal pDate As CritereDate)
            mPoste.visite_medicale_a_jour = pDate
        End Sub

        ' ------------------------------ Function Poste Begin --------------------------------------



        Private Sub Ajouter_Agence_Statut_Cdi_tt(ByVal pFlag As Boolean, ByVal pPriorite As Integer)
            mAgence.statut_cdi_tt = GetCritereFlag(pFlag, pPriorite)
        End Sub

        Private Sub Ajouter_Agence_TT_400h(ByVal pFlag As Boolean, ByVal pPriorite As Integer)
            mAgence.tt_400h = GetCritereFlag(pFlag, pPriorite)
        End Sub

        Private Sub Ajouter_Agence_FSPI(ByVal pFspi As String)
            mAgence.fspi = pFspi
        End Sub


        Private Function GetCritereReferentiel(ByVal pCode As String, ByVal pLibelle As String, ByVal pPriorite As Integer) As CritereReferentiel
            Dim lRef As New CritereReferentiel()
            lRef.referentiel = New classes_xml_generees.LibRechProfil.Referentiel()
            lRef.priorite = pPriorite
            lRef.prioriteSpecified = True
            lRef.referentiel.code = pCode
            lRef.referentiel.libelle = pLibelle
            Return lRef
        End Function

        Private Function GetCritereFloat(ByVal pNombre As Single, ByVal pPriorite As Integer) As CritereFloat
            Dim lCritereFloat As New CritereFloat()
            lCritereFloat.nombre = pNombre
            lCritereFloat.nombreSpecified = True
            lCritereFloat.priorite = pPriorite
            lCritereFloat.prioriteSpecified = True
            Return lCritereFloat
        End Function

        Private Function GetCritereDate(ByVal pDate As Date, ByVal pPriorite As Integer) As CritereDate
            Dim lCritereDate As New CritereDate()
            lCritereDate.date = pDate
            lCritereDate.dateSpecified = True
            lCritereDate.priorite = pPriorite
            lCritereDate.prioriteSpecified = True
            Return lCritereDate
        End Function

        Private Function GetCritereFlag(ByVal pflag As Boolean, ByVal pPriorite As Integer) As CritereFlag
            Dim lCritereFlag As New CritereFlag()
            lCritereFlag.flag = pflag
            lCritereFlag.flagSpecified = True
            lCritereFlag.priorite = pPriorite
            lCritereFlag.prioriteSpecified = True
            Return lCritereFlag
        End Function
    End Class

End Namespace
